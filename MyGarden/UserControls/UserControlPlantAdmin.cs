using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MyGarden
{
    public partial class UserControlPlantAdmin : UserControl
    {
        public event EventHandler ClickedExit;
        private UserControlActionAdmin ActionAdminUC;
        private Plant selectedPlant;

        private ICollection<Plant> plants;
        private ICollection<PlantType> plantTypes;

        private ICollection<Plant> Plants
        {
            get
            {
                return plants;
            }
            set
            {
                plants = value;

                listBoxPlants.Items.Clear();

                foreach (Plant plant in plants)
                {
                    listBoxPlants.Items.Add(plant);
                }
            }
        }

        private ICollection<PlantType> PlantTypes
        {
            get
            {
                return plantTypes;
            }
            set
            {
                plantTypes = value;

                comboBoxPlantTypes.Items.Clear();
                comboBoxPlantTypes.DisplayMember = "Name";
                comboBoxPlantTypes.ValueMember = "Id";

                foreach (PlantType plantType in plantTypes)
                {
                    comboBoxPlantTypes.Items.Add(plantType);
                }
            }
        }

        public UserControlPlantAdmin()
        {
            InitializeComponent();
        }

        private void PlantListBox_Load(object sender, EventArgs e)
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
                        var plants = db.Plants.ToList();

                        Plants = db.Plants
                            .ToList();

                        PlantTypes = db.PlantTypes.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPlantAsSelected(string nameToSelect)
        {
            int i = 0;
            foreach (Plant plant in listBoxPlants.Items)
            {
                if (plant.Name == nameToSelect)
                {
                    break;
                }
                i++;
            }
            if (i < listBoxPlants.Items.Count)
            {
                listBoxPlants.SetSelected(i, true);
            }
        }

        private void ClearSelected()
        {
            listBoxPlants.ClearSelected();
            ActionAdminUC.SelectedPlant = null;
            selectedPlant = new Plant();
            ShowPlant(selectedPlant);

            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void ShowPlant(Plant plant)
        {
            textBoxPlantName.Text = plant.Name;
            if (plant.PlantType == null)
            {
                comboBoxPlantTypes.SelectedItem = null;
                comboBoxPlantTypes.Text = null;
            }
            else
            {
                comboBoxPlantTypes.SelectedItem = plant.PlantType;
                comboBoxPlantTypes.Text = plant.PlantType.Name;
            }
        }

        private bool IsPlantNameValid(MyGardenContext db, string name, int id, out string message)
        {
            message = null;
            if (name == "")
            {
                message = "Please enter a Plant name.";
                return false;
            }

            Plant plant = db.Plants.FirstOrDefault(p => p.Name == name);
            if (plant != null && plant.Id != id)
            {
                message = $"There is already a Plant called '{name}'. Please, try another name.";
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddPlant(out string message))
            {
                LoadData();
                SetPlantAsSelected(textBoxPlantName.Text);
                toolStripLabel.Text = $"'{textBoxPlantName.Text}' is added.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddPlant(out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsPlantNameValid(db, textBoxPlantName.Text, 0, out message))
                        {
                            Plant plantToAdd = new Plant();
                            plantToAdd.Name = textBoxPlantName.Text;

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.Plants.Add(plantToAdd);
                            db.SaveChanges();
                            selectedPlant = plantToAdd;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error adding Plant '{textBoxPlantName.Text}': {ex.Message}";
            }

            return result;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Plant plant = listBoxPlants.SelectedItem as Plant;
            if (MessageBox.Show(
                        $"Do you want to delete {plant.Name}? \n" +
                        $"(All Actions for this Plant will also be deleted)",
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
                            Plant plantToDelete = db.Plants.FirstOrDefault(p => p.Id == plant.Id);

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.Plants.Remove(plantToDelete);
                            db.SaveChanges();

                            LoadData();
                            ClearSelected();
                            toolStripLabel.Text = $"'{plantToDelete.Name}' is deleted.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting Plant '{plant.Name}': {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UpdatePlant(selectedPlant, out string message))
            {
                LoadData();
                SetPlantAsSelected(textBoxPlantName.Text);
                toolStripLabel.Text = $"'{textBoxPlantName.Text}' is saved.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePlant(Plant plant, out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsPlantNameValid(db, textBoxPlantName.Text, plant.Id, out message))
                        {
                            Plant plantToUpdate = db.Plants.FirstOrDefault(p => p.Id == plant.Id);
                            if (plantToUpdate != null)
                            {
                                plantToUpdate.Name = textBoxPlantName.Text;
                            }

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.SaveChanges();
                            selectedPlant = plantToUpdate;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error saving Plant '{textBoxPlantName.Text}': {ex.Message}";
            }
            return result;
        }

        private void listBoxPlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plant plant = listBoxPlants.SelectedItem as Plant;

            string message = null;
            if (CheckIfNeedsSaving(selectedPlant, out message))
            {
                if (message == null)
                {
                    toolStripLabel.Text = $"'{textBoxPlantName.Text}' is saved.";

                    LoadData();
                    SetPlantAsSelected(plant.Name);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowPlant(selectedPlant);
                    SetPlantAsSelected(selectedPlant.Name);
                    ActionAdminUC.SelectedPlant = selectedPlant;
                }
            }
            else
            {
                selectedPlant = plant;
                ShowPlant(plant);
                ActionAdminUC.SelectedPlant = plant;
            }

            buttonSave.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void comboBoxPlantTypes_Enter(object sender, EventArgs e)
        {
            comboBoxPlantTypes.DroppedDown = true;
        }

        private void UserControlPlantAdmin_Leave(object sender, EventArgs e)
        {
            if (CheckIfNeedsSaving(selectedPlant, out string message))
            {
                if (message == null)
                {
                    MessageBox.Show($"'{textBoxPlantName.Text}' is saved.",
                              "Saved changes",
                              MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckIfNeedsSaving(Plant plant, out string message)
        {
            bool updated = false;
            message = null;
            if ((plant.Name != null || textBoxPlantName.Text != "") &&
                plant.Name != textBoxPlantName.Text
                )
            {
                if (MessageBox.Show($"Do you want to save '{textBoxPlantName.Text}'?",
                            "Confirm Leave",
                            MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if (plant.Id == 0)
                    {
                        updated = AddPlant(out message);
                    }
                    else
                    {
                        updated = UpdatePlant(plant, out message);
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
