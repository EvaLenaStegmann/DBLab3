using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace MyGarden
{
    public partial class UserControlActionAdmin : UserControl
    {
        private Location selectedLocation;
        public Location SelectedLocation 
        { 
            get 
            { 
                return selectedLocation; 
            } 
            set 
            { 
                selectedLocation = value; 
                if (selectedLocation != null)
                {
                    selectedPlant = null;
                    loadData();
                }
                else
                {
                    if (selectedPlant == null)
                    {
                        dataGridViewActions.Rows.Clear();
                    }
                }
            } 
        }

        private Plant selectedPlant;
        public Plant SelectedPlant 
        { 
            get 
            { 
                return selectedPlant; 
            } 
            set 
            { 
                selectedPlant = value;
                if (selectedPlant != null)
                {
                    selectedLocation = null;
                    loadData();
                }
                else
                {
                    if (selectedLocation == null)
                    {
                        dataGridViewActions.Rows.Clear();
                    }
                }
            } 
        }

        private ICollection<Action> Actions { get; set; }

        private ICollection<ActionType> ActionTypes { get; set; }
        private ICollection<Plant> Plants { get; set; }
        private ICollection<Location> Locations { get; set; }

        public UserControlActionAdmin()
        {
            InitializeComponent();
        }

        private void UserControlActionAdmin_Load(object sender, EventArgs e)
        {
            if (Parent.Parent is UserControlLocationAdmin) 
            {
                dataGridViewActions.Columns["Location"].Visible = false;
            }
            else if (Parent.Parent is UserControlPlantAdmin)
            {
                dataGridViewActions.Columns["Plant"].Visible = false;
            }
         }

        private void FillLocationComboBox(int rowIndex)
        {
            var comboBoxCellLocation = dataGridViewActions.Rows[rowIndex].Cells["Location"] as DataGridViewComboBoxCell;
            comboBoxCellLocation.ValueType = typeof(Location);
            comboBoxCellLocation.DisplayMember = "Name";
            comboBoxCellLocation.ValueMember = "This";

            foreach (Location location in Locations)
            {
                comboBoxCellLocation.Items.Add(location);
            }
        }

        private void FillPlantComboBox(int rowIndex)
        {
            var comboBoxCellPlant = dataGridViewActions.Rows[rowIndex].Cells["Plant"] as DataGridViewComboBoxCell;
            comboBoxCellPlant.ValueType = typeof(Plant);
            comboBoxCellPlant.DisplayMember = "Name";
            comboBoxCellPlant.ValueMember = "This";

            foreach (Plant plant in Plants)
            {
                comboBoxCellPlant.Items.Add(plant);
            }
        }

        private void FillActionTypeComboBox(int rowIndex)
        {
            var comboBoxCellActionType = dataGridViewActions.Rows[rowIndex].Cells["ActionType"] as DataGridViewComboBoxCell;
            comboBoxCellActionType.ValueType = typeof(ActionType);
            comboBoxCellActionType.DisplayMember = "Name";
            comboBoxCellActionType.ValueMember = "This";

            foreach (ActionType actionType in ActionTypes)
            {
                comboBoxCellActionType.Items.Add(actionType);
            }
        }

        private void loadData()
        {
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        DataGridViewComboBoxColumn comboBoxColumn;
                        Plants = db.Plants.ToList();
                        ActionTypes = db.ActionTypes.ToList();
                        Locations = db.Locations.ToList();

                        dataGridViewActions.Columns.Clear();
                        dataGridViewActions.Rows.Clear();

                        if (selectedLocation == null)
                        {
                            comboBoxColumn = new DataGridViewComboBoxColumn
                            {
                                HeaderText = "Location:",
                                Name = "Location"
                            };
                            dataGridViewActions.Columns.Add(comboBoxColumn);
                        }
                        else
                        {
                            loadActionsFromLocation(db);
                            dataGridViewActions.Columns.Add("Location", "Location:");
                            dataGridViewActions.Columns["Location"].Visible = false;
                        }

                        if (selectedPlant == null)
                        {
                            comboBoxColumn = new DataGridViewComboBoxColumn
                            {
                                HeaderText = "Plant:",
                                Name = "Plant"
                            };
                            dataGridViewActions.Columns.Add(comboBoxColumn);
                        }
                        else
                        {
                            loadActionsFromPlant(db);
                            dataGridViewActions.Columns.Add("Plant", "Plant:");
                            dataGridViewActions.Columns["Plant"].Visible = false;
                        }

                        comboBoxColumn = new DataGridViewComboBoxColumn
                        {
                            HeaderText = "Action Type:",
                            Name = "ActionType"
                        };
                        dataGridViewActions.Columns.Add(comboBoxColumn);

                        dataGridViewActions.Columns.Add("ActionDate", "Action Date and Time:");
                        dataGridViewActions.Columns.Add("HarvestSeason", "Harvest Season:");

                        loadDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadActionsFromLocation(MyGardenContext db)
        {
            Actions = db.Actions
                .Where(a => a.LocationId == SelectedLocation.Id)
                .OrderByDescending(a => a.ActionDate)
                .ToList();
        }

        private void loadActionsFromPlant(MyGardenContext db)
        {
            Actions = db.Actions
                .Where(a => a.PlantId == SelectedPlant.Id)
                .OrderByDescending(a => a.ActionDate)
                .ToList();
        }

        private void loadDataGridView()
        {
            foreach (Action action in Actions)
            {
                int rowIndex = dataGridViewActions.Rows.Add();
                dataGridViewActions.Rows[rowIndex].Tag = action;

                if (dataGridViewActions.Rows[rowIndex].Cells["Location"].GetType().Name == "DataGridViewComboBoxCell")
                {
                    FillLocationComboBox(rowIndex);
                }
                if (dataGridViewActions.Rows[rowIndex].Cells["Plant"].GetType().Name == "DataGridViewComboBoxCell")
                {
                    FillPlantComboBox(rowIndex);
                }
                FillActionTypeComboBox(rowIndex);

                dataGridViewActions.Rows[rowIndex].Cells["Location"].Value = action.Location;
                dataGridViewActions.Rows[rowIndex].Cells["Plant"].Value = action.Plant;
                dataGridViewActions.Rows[rowIndex].Cells["ActionType"].Value = action.ActionType;
                dataGridViewActions.Rows[rowIndex].Cells["ActionDate"].Value = action.ActionDate;
                dataGridViewActions.Rows[rowIndex].Cells["HarvestSeason"].Value = action.HarvestSeason;

                dataGridViewActions.Rows[rowIndex].Cells["Location"].ReadOnly = true;
                dataGridViewActions.Rows[rowIndex].Cells["Plant"].ReadOnly = true;
            }
        }

        private void dataGridViewActions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedLocation == null && selectedPlant == null)
            {
                return;
            }

            if (e.RowIndex == dataGridViewActions.NewRowIndex)
            {
                Action action = new Action();
                if (selectedLocation == null)
                {
                    FillLocationComboBox(e.RowIndex);
                }
                else
                {
                    dataGridViewActions.Rows[e.RowIndex].Cells["Location"].Value = selectedLocation.Name;
                    action.LocationId = selectedLocation.Id;
                    dataGridViewActions.Rows[e.RowIndex].Cells["Location"].ReadOnly = true;
                }
                if (selectedPlant == null)
                {
                    FillPlantComboBox(e.RowIndex);
                }
                else
                {
                    dataGridViewActions.Rows[e.RowIndex].Cells["Plant"].Value = selectedPlant.Name;
                    action.PlantId = selectedPlant.Id;
                    dataGridViewActions.Rows[e.RowIndex].Cells["Plant"].ReadOnly = true;
                }

                FillActionTypeComboBox(e.RowIndex);

                action.ActionDate = DateTime.Now;
                dataGridViewActions.Rows[e.RowIndex].Cells["ActionDate"].Value = action.ActionDate;
                action.HarvestSeason = (short)action.ActionDate.Year;
                dataGridViewActions.Rows[e.RowIndex].Cells["HarvestSeason"].Value = action.HarvestSeason;

                dataGridViewActions.Rows[e.RowIndex].Tag = action;
            }
        }

        private void dataGridViewActions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Action actionToUpdate;
            if (e.RowIndex == dataGridViewActions.NewRowIndex)
            {
                actionToUpdate = new Action();
            }
            else
            {
                actionToUpdate = dataGridViewActions.Rows[e.RowIndex].Tag as Action;
            }

            var cell = dataGridViewActions.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (actionToUpdate.Id == 0)
            {
                if (dataGridViewActions.Rows[e.RowIndex].Cells["Location"].Value == null ||
                    dataGridViewActions.Rows[e.RowIndex].Cells["Plant"].Value == null ||
                    dataGridViewActions.Rows[e.RowIndex].Cells["ActionType"].Value == null)
                {
                    return;
                }
            }

            if (!NeedsUpdating(actionToUpdate, cell))
            {
                return;
            }

            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (actionToUpdate.Id != 0)
                        {
                            actionToUpdate = db.Actions.FirstOrDefault(a => a.Id == actionToUpdate.Id);

                            if (cell.OwningColumn.Name == "ActionType")
                            {
                                actionToUpdate.ActionType = cell.Value as ActionType;
                            }
                            if (cell.OwningColumn.Name == "ActionDate")
                            {
                                actionToUpdate.ActionDate = DateTime.Parse(cell.Value.ToString());
                            }
                            if (cell.OwningColumn.Name == "HarvestSeason")
                            {
                                actionToUpdate.HarvestSeason = short.Parse(cell.Value.ToString());
                            }
                        }
                        else
                        {
                            if (selectedLocation == null)
                            {
                                var location = dataGridViewActions.Rows[e.RowIndex].Cells["Location"].Value as Location;
                                actionToUpdate.LocationId = location.Id;
                            }

                            if (selectedPlant == null)
                            {
                                var plant = dataGridViewActions.Rows[e.RowIndex].Cells["Plant"].Value as Plant;
                                actionToUpdate.PlantId = plant.Id;
                            }

                            var actionType = dataGridViewActions.Rows[e.RowIndex].Cells["ActionType"].Value as ActionType;
                            actionToUpdate.ActionTypeId = actionType.Id;

                            db.Add(actionToUpdate);
                        }

                        var trackedObjects = db.ChangeTracker.Entries();
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool NeedsUpdating(Action actionToUpdate, DataGridViewCell cell)
        {
            bool updateNeeded = false;
            string changedCellName = cell.OwningColumn.Name;
            switch (changedCellName)
            {
                case "Location":
                    var location = cell.Value as Location;
                    if (location != null && location.Id != actionToUpdate.LocationId)
                    {
                        updateNeeded = true;
                    }
                    break;
                case "Plant":
                    var plant = cell.Value as Plant;
                    if (plant != null && plant.Id != actionToUpdate.PlantId)
                    {
                        updateNeeded = true;
                    }
                    break;
                case "ActionType":
                    var actionType = cell.Value as ActionType;
                    if (actionType != null && actionType.Id != actionToUpdate.ActionTypeId)
                    {
                        updateNeeded = true;
                    }
                    break;
                case "ActionDate":
                    if (DateTime.Parse(cell.Value.ToString()) != actionToUpdate.ActionDate)
                    {
                        updateNeeded = true;
                    }
                    break;
                case "HarvestSeason":
                    if (short.Parse(cell.Value.ToString()) != actionToUpdate.HarvestSeason)
                    {
                        updateNeeded = true;
                    }
                    break;
                default:
                    break;
            }
            return updateNeeded;
        }

        private void dataGridViewActions_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewActions.SelectedRows.Count > 0)
            {
                Action actionToDelete = dataGridViewActions.SelectedRows[0].Tag as Action;

                if (MessageBox.Show(
                            $"Do you want to delete this action?",
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
                                db.Remove(actionToDelete);
                                db.SaveChanges();
                                dataGridViewActions.ClearSelection();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error when deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridViewActions_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Action actionToUpdate;
            if (e.RowIndex == dataGridViewActions.NewRowIndex)
            {
                actionToUpdate = new Action();
            }
            else
            {
                actionToUpdate = dataGridViewActions.Rows[e.RowIndex].Tag as Action;
            }

            var cell = dataGridViewActions.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string result = ValidateInput(actionToUpdate, cell);
            if (result != null)
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private string ValidateInput(Action actionToUpdate, DataGridViewCell cell)
        {
            string changedCellName = cell.OwningColumn.Name;
            switch (changedCellName)
            {
                case "ActionDate":
                    DateTime actionDate;
                    if (DateTime.TryParse(cell.EditedFormattedValue.ToString(), out actionDate))
                    {
                        if (actionDate > DateTime.Now)
                        {
                            return "Action Date and Time must be in the passed";
                        }
                    }
                    else 
                    { 
                        return "Please enter a valid date and time (YYYY-MM-DD HH:MM.SS)";
                    }
                    break;
                case "HarvestSeason":
                    short harvestSeason;
                    if (short.TryParse(cell.EditedFormattedValue.ToString(), out harvestSeason))
                    {
                        if (harvestSeason < actionToUpdate.ActionDate.Year)
                        {
                            return "Harvest Season can not be before Action year";
                        }
                    }
                    else
                    { 
                        return "Please enter a valid year (YYYY)";
                    }
                    break;
                default:
                    break;
            }
            return null;
        }

    }
}
