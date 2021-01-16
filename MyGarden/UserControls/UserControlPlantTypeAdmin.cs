using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MyGarden
{
    public partial class UserControlPlantTypeAdmin : UserControl
    {
        public event EventHandler ClickedExit;
        private PlantType selectedPlantType;

        private ICollection<PlantType> plantTypes;
        private ICollection<PlantType> PlantTypes
        {
            get
            {
                return plantTypes;
            }
            set
            {
                plantTypes = value;

                listBoxPlantTypes.Items.Clear();

                foreach (PlantType plantType in plantTypes)
                {
                    listBoxPlantTypes.Items.Add(plantType);
                }
            }
        }

        public UserControlPlantTypeAdmin()
        {
            InitializeComponent();
        }

        private void UserControlPlantTypeAdmin_Load(object sender, EventArgs e)
        {
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
                        var plantTypes = db.PlantTypes.ToList();

                        PlantTypes = db.PlantTypes
                            .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPlantTypeAsSelected(string nameToSelect)
        {
            int i = 0;
            foreach (PlantType plantType in listBoxPlantTypes.Items)
            {
                if (plantType.Name == nameToSelect)
                {
                    break;
                }
                i++;
            }
            if (i < listBoxPlantTypes.Items.Count)
            {
                listBoxPlantTypes.SetSelected(i, true);
            }
        }

        private void ClearSelected()
        {
            listBoxPlantTypes.ClearSelected();
            selectedPlantType = new PlantType();
            ShowPlantType(selectedPlantType);

            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void ShowPlantType(PlantType plantType)
        {
            textBoxPlantTypeName.Text = plantType.Name;
            radioButtonYes.Checked = plantType.Perennial;
            radioButtonNo.Checked = !plantType.Perennial;
            textBoxSoil.Text = plantType.Soil;
            textBoxNutrition.Text = plantType.Nutrition;
            textBoxInfo.Text = plantType.Info;
        }

        private bool IsPlantTypeNameValid(MyGardenContext db, string name, int id, out string message)
        {
            message = null;
            if (name == "")
            {
                message = "Please enter a Plant Type name.";
                return false;
            }

            PlantType plantType = db.PlantTypes.FirstOrDefault(p => p.Name == name);
            if (plantType != null && plantType.Id != id)
            {
                message =  $"There is already a Plant Type called '{name}'. Please try another name.";
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddPlantType(out string message))
            {
                LoadData();
                SetPlantTypeAsSelected(textBoxPlantTypeName.Text);
                toolStripLabel.Text = $"'{textBoxPlantTypeName.Text}' is added.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddPlantType(out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsPlantTypeNameValid(db, textBoxPlantTypeName.Text, 0, out message))
                        {
                            PlantType plantTypeToAdd = new PlantType();
                            plantTypeToAdd.Name = textBoxPlantTypeName.Text;
                            plantTypeToAdd.Perennial = radioButtonYes.Checked;
                            plantTypeToAdd.Soil = textBoxSoil.Text;
                            plantTypeToAdd.Nutrition = textBoxNutrition.Text;
                            plantTypeToAdd.Info = textBoxInfo.Text;

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.PlantTypes.Add(plantTypeToAdd);
                            db.SaveChanges();
                            selectedPlantType = plantTypeToAdd;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error adding Plant Type '{textBoxPlantTypeName.Text}': {ex.Message}";
            }

            return result;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            PlantType plantType = listBoxPlantTypes.SelectedItem as PlantType;
            if (MessageBox.Show(
                        $"Do you want to delete {plantType.Name}? \n" +
                        $"(All Plants and its Actions with this Plant Type will also be deleted)",
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
                            PlantType plantTypeToDelete = db.PlantTypes.FirstOrDefault(p => p.Id == plantType.Id);

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.PlantTypes.Remove(plantTypeToDelete);
                            db.SaveChanges();

                            LoadData();
                            ClearSelected();
                            toolStripLabel.Text = $"'{plantTypeToDelete.Name}' is deleted.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting Plant Type '{plantType.Name}': {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UpdatePlantType(selectedPlantType, out string message))
            {
                LoadData();
                SetPlantTypeAsSelected(textBoxPlantTypeName.Text);
                toolStripLabel.Text = $"'{textBoxPlantTypeName.Text}' is saved.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePlantType(PlantType plantType, out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsPlantTypeNameValid(db, textBoxPlantTypeName.Text, plantType.Id, out message))
                        {
                            PlantType plantTypeToUpdate = db.PlantTypes.FirstOrDefault(p => p.Id == plantType.Id);
                            if (plantTypeToUpdate != null)
                            {
                                plantTypeToUpdate.Name = textBoxPlantTypeName.Text;
                                plantTypeToUpdate.Perennial = radioButtonYes.Checked;
                                plantTypeToUpdate.Soil = textBoxSoil.Text;
                                plantTypeToUpdate.Nutrition = textBoxNutrition.Text;
                                plantTypeToUpdate.Info = textBoxInfo.Text;
                            }

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.SaveChanges();
                            selectedPlantType = plantTypeToUpdate;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error saving Plant Type '{textBoxPlantTypeName.Text}': {ex.Message}";
            }
            return result;
        }

        private void listBoxPlantTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlantType plantType = listBoxPlantTypes.SelectedItem as PlantType;

            string message = null;
            if (CheckIfNeedsSaving(selectedPlantType, out message))
            {
                if (message == null)
                {
                    toolStripLabel.Text = $"'{textBoxPlantTypeName.Text}' is saved.";

                    LoadData();
                    SetPlantTypeAsSelected(plantType.Name);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowPlantType(selectedPlantType);
                    SetPlantTypeAsSelected(selectedPlantType.Name);
                }
            }
            else
            {
                selectedPlantType = plantType;
                ShowPlantType(plantType);
            }

            buttonSave.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void UserControlPlantTypeAdmin_Leave(object sender, EventArgs e)
        {
            if (CheckIfNeedsSaving(selectedPlantType, out string message))
            {
                if (message == null)
                {
                    MessageBox.Show($"'{textBoxPlantTypeName.Text}' is saved.",
                              "Saved changes",
                              MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckIfNeedsSaving(PlantType plantType, out string message)
        {
            bool updated = false;
            message = null;

            string plantTypeSoil = plantType.Soil ?? "";
            string plantTypeNutrition = plantType.Nutrition ?? "";
            string plantTypeInfo = plantType.Info ?? "";
            if ((plantType.Name != null || textBoxPlantTypeName.Text != "") &&
                (plantType.Name != textBoxPlantTypeName.Text ||
                 plantType.Perennial != radioButtonYes.Checked ||
                 plantTypeSoil != textBoxSoil.Text ||
                 plantTypeNutrition != textBoxNutrition.Text ||
                 plantTypeInfo != textBoxInfo.Text
                )
                )
            {
                if (MessageBox.Show($"Do you want to save '{textBoxPlantTypeName.Text}'?",
                            "Confirm Leave",
                            MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if (plantType.Id == 0)
                    {
                        updated = AddPlantType(out message);
                    }
                    else
                    {
                        updated = UpdatePlantType(plantType, out message);
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
