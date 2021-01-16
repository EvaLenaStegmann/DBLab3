using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyGarden
{
    public partial class UserControlActionTypeAdmin : UserControl
    {
        public event EventHandler ClickedExit;
        private ActionType selectedActionType;

        private ICollection<ActionType> actionTypes;
        private ICollection<ActionType> ActionTypes
        {
            get
            {
                return actionTypes;
            }
            set
            {
                actionTypes = value;

                listBoxActionTypes.Items.Clear();

                foreach (ActionType actionType in actionTypes)
                {
                    listBoxActionTypes.Items.Add(actionType);
                }
            }
        }

        public UserControlActionTypeAdmin()
        {
            InitializeComponent();
        }

        private void UserControlActionTypeAdmin_Load(object sender, EventArgs e)
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
                        var actionTypes = db.ActionTypes.ToList();

                        ActionTypes = db.ActionTypes
                            .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetActionTypeAsSelected(string nameToSelect)
        {
            int i = 0;
            foreach (ActionType actionType in listBoxActionTypes.Items)
            {
                if (actionType.Name == nameToSelect)
                {
                    break;
                }
                i++;
            }
            if (i < listBoxActionTypes.Items.Count)
            {
                listBoxActionTypes.SetSelected(i, true);
            }
        }

        private void ClearSelected()
        {
            listBoxActionTypes.ClearSelected();
            selectedActionType = new ActionType();
            ShowActionType(selectedActionType);

            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void ShowActionType(ActionType actionType)
        {
            textBoxActionTypeName.Text = actionType.Name;
        }

        private bool IsActionTypeNameValid(MyGardenContext db, string name, int id, out string message)
        {
            message = null;
            if (name == "")
            {
                message = "Please enter a Action Type name.";
                return false;
            }

            ActionType actionType = db.ActionTypes.FirstOrDefault(p => p.Name == name);
            if (actionType != null && actionType.Id != id)
            {
                message = $"There is already a Action Type called '{name}'. Please try another name.";
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddActionType(out string message))
            {
                LoadData();
                SetActionTypeAsSelected(textBoxActionTypeName.Text);
                toolStripLabel.Text = $"'{textBoxActionTypeName.Text}' is added.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddActionType(out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsActionTypeNameValid(db, textBoxActionTypeName.Text, 0, out message))
                        {
                            ActionType actionTypeToAdd = new ActionType();
                            actionTypeToAdd.Name = textBoxActionTypeName.Text;

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.ActionTypes.Add(actionTypeToAdd);
                            db.SaveChanges();
                            selectedActionType = actionTypeToAdd;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error adding Action Type '{textBoxActionTypeName.Text}': {ex.Message}";
            }

            return result;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ActionType actionType = listBoxActionTypes.SelectedItem as ActionType;
            if (MessageBox.Show(
                        $"Do you want to delete '{actionType.Name}'? \n" +
                        $"(All Actions with this Action Type will also be deleted)",
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
                            ActionType actionTypeToDelete = db.ActionTypes.FirstOrDefault(p => p.Id == actionType.Id);

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.ActionTypes.Remove(actionTypeToDelete);
                            db.SaveChanges();

                            LoadData();
                            ClearSelected();
                            toolStripLabel.Text = $"'{actionTypeToDelete.Name}' is deleted.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting Action Type '{actionType.Name}': {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UpdateActionType(selectedActionType, out string message))
            {
                LoadData();
                SetActionTypeAsSelected(textBoxActionTypeName.Text);
                toolStripLabel.Text = $"'{textBoxActionTypeName.Text}' is saved.";
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateActionType(ActionType actionType, out string message)
        {
            bool result = false;
            message = null;
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        if (IsActionTypeNameValid(db, textBoxActionTypeName.Text, actionType.Id, out message))
                        {
                            ActionType actionTypeToUpdate = db.ActionTypes.FirstOrDefault(p => p.Id == actionType.Id);
                            if (actionTypeToUpdate != null)
                            {
                                actionTypeToUpdate.Name = textBoxActionTypeName.Text;
                            }

                            var trackedObjects = db.ChangeTracker.Entries();
                            db.SaveChanges();
                            selectedActionType = actionTypeToUpdate;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Error saving Action Type '{textBoxActionTypeName.Text}': {ex.Message}";
            }
            return result;
        }

        private void listBoxActionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionType actionType = listBoxActionTypes.SelectedItem as ActionType;

            string message = null;
            if (CheckIfNeedsSaving(selectedActionType, out message))
            {
                if (message == null)
                {
                    toolStripLabel.Text = $"'{textBoxActionTypeName.Text}' is saved.";

                    LoadData();
                    SetActionTypeAsSelected(actionType.Name);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowActionType(selectedActionType);
                    SetActionTypeAsSelected(selectedActionType.Name);
                }
            }
            else
            {
                selectedActionType = actionType;
                ShowActionType(actionType);
            }

            buttonSave.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void UserControlActionTypeAdmin_Leave(object sender, EventArgs e)
        {
            if (CheckIfNeedsSaving(selectedActionType, out string message))
            {
                if (message == null)
                {
                    MessageBox.Show($"'{textBoxActionTypeName.Text}' is saved.",
                              "Saved changes",
                              MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckIfNeedsSaving(ActionType actionType, out string message)
        {
            bool updated = false;
            message = null;
            if ((actionType.Name != null || textBoxActionTypeName.Text != "") &&
                actionType.Name != textBoxActionTypeName.Text
                )
            {
                if (MessageBox.Show($"Do you want to save '{textBoxActionTypeName.Text}'?",
                            "Confirm Leave",
                            MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if (actionType.Id == 0)
                    {
                        updated = AddActionType(out message);
                    }
                    else
                    {
                        updated = UpdateActionType(actionType, out message);
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
