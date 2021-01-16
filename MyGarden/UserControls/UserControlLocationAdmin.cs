using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MyGarden
{
    public partial class UserControlLocationAdmin : UserControl
    {
        public event EventHandler ClickedExit; 
        private UserControlActionAdmin ActionAdminUC;
        private Location selectedLocation;

        private ICollection<Location> locations;
        private ICollection<Location> Locations
        {
            get
            {
                return locations;
            }
            set
            {
                locations = value;

                listBoxLocations.Items.Clear();

                foreach (Location location in locations)
                {
                    listBoxLocations.Items.Add(location);
                }
            }
        }
        public UserControlLocationAdmin()
        {
            InitializeComponent();
        }

        private void UserControlLocationAdmin_Load(object sender, EventArgs e)
        {
            ActionAdminUC = new UserControlActionAdmin() { Dock = DockStyle.Fill };
            panel1.Controls.Add(ActionAdminUC);

            LoadData();
            ClearSelected();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        var locations = db.Locations.ToList();

                        Locations = db.Locations
                            .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetLocationAsSelected(string nameToSelect)
        {
            int i = 0;
            foreach (Location location in listBoxLocations.Items)
            {
                if (location.Name == nameToSelect)
                {
                    break;
                }
                i++;
            }
            if (i < listBoxLocations.Items.Count)
            {
                listBoxLocations.SetSelected(i, true);
            }
        }

        private void ClearSelected()
        {
            listBoxLocations.ClearSelected();
            ActionAdminUC.SelectedLocation = null;
            selectedLocation = new Location();
            ShowLocation(selectedLocation);

            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void ShowLocation(Location location)
        {
            textBoxLocationName.Text = location.Name;
        }

        private bool IsLocationNameValid(MyGardenContext db, string name, int id, out string message)
        {
            message = null;
            if (name == "")
            {
                message =  "Please enter a Location name.";
                return false;
            }

            Location location = db.Locations.FirstOrDefault(p => p.Name == name);
            if (location != null && location.Id != id)
            {
                message =  $"There is already a Location called '{name}'. Please, try another name.";
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddLocation(out string message))
            {
                LoadData();
                SetLocationAsSelected(textBoxLocationName.Text);
                toolStripLabel.Text = $"'{textBoxLocationName.Text}' is added.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddLocation(out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsLocationNameValid(db, textBoxLocationName.Text, 0, out message))
                        {
                            Location locationToAdd = new Location();
                            locationToAdd.Name = textBoxLocationName.Text;

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.Locations.Add(locationToAdd);
                            db.SaveChanges();
                            selectedLocation = locationToAdd;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error adding Location '{textBoxLocationName.Text}': {ex.Message}";
            }

            return result;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Location location = listBoxLocations.SelectedItem as Location;
            if (MessageBox.Show(
                        $"Do you want to delete {location.Name}? \n" +
                        $"(All Actions at this Location will also be deleted)",
                        "Confirm Delete", 
                        MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MyGardenContext())
                    {
                        if (db.Database.CanConnect())
                        {
                            Location locationToDelete = db.Locations.FirstOrDefault(p => p.Id == location.Id);

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.Locations.Remove(locationToDelete);
                            db.SaveChanges();

                            LoadData();
                            ClearSelected();
                            toolStripLabel.Text = $"'{locationToDelete.Name}' is deleted.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting Location '{location.Name}': {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }    
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UpdateLocation(selectedLocation, out string message))
            {
                LoadData();
                SetLocationAsSelected(textBoxLocationName.Text);
                toolStripLabel.Text = $"'{textBoxLocationName.Text}' is saved.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateLocation(Location location, out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsLocationNameValid(db, textBoxLocationName.Text, location.Id, out message))
                        {
                            Location locationToUpdate = db.Locations.FirstOrDefault(p => p.Id == location.Id);
                            if (locationToUpdate != null)
                            {
                                locationToUpdate.Name = textBoxLocationName.Text;
                            }

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.SaveChanges();
                            selectedLocation = locationToUpdate;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error saving Location '{textBoxLocationName.Text}': {ex.Message}";
            }
            return result;
        }

        private void listBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Location location = listBoxLocations.SelectedItem as Location;

            string message = null;
            if (CheckIfNeedsSaving(selectedLocation, out message))
            {
                if (message == null)
                {
                    toolStripLabel.Text = $"'{textBoxLocationName.Text}' is saved.";

                    LoadData();
                    SetLocationAsSelected(location.Name);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowLocation(selectedLocation);
                    SetLocationAsSelected(selectedLocation.Name);
                    ActionAdminUC.SelectedLocation = selectedLocation;
                }
            }
            else
            {
                selectedLocation = location;
                ShowLocation(location);
                ActionAdminUC.SelectedLocation = location;
            }

            buttonSave.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void UserControlLocationAdmin_Leave(object sender, EventArgs e)
        {
            if (CheckIfNeedsSaving(selectedLocation, out string message))
            {
                if (message == null)
                {
                    MessageBox.Show($"'{textBoxLocationName.Text}' is saved.",
                              "Saved changes",
                              MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckIfNeedsSaving(Location location, out string message)
        {
            bool updated = false;
            message = null;
            if ((location.Name != null || textBoxLocationName.Text != "") &&
                location.Name != textBoxLocationName.Text
                )
            {
                if (MessageBox.Show($"Do you want to save '{textBoxLocationName.Text}'?",
                            "Confirm Leave",
                            MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if (location.Id == 0)
                    {
                        updated = AddLocation(out message);
                    }
                    else
                    {
                        updated = UpdateLocation(location, out message);
                    }
                    updated = true;
                }
            }
            return updated;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ClickedExit?.Invoke(this, null);
        }
    }
}
