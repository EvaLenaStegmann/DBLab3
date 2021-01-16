using System;
using System.Windows.Forms;

namespace MyGarden
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItemPlantTypesPerLocation.PerformClick();
        }

        private void toolStripMenuItemPlants_Click(object sender, EventArgs e)
        {
            var plantAdminUC = new UserControlPlantAdmin() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(plantAdminUC);
            plantAdminUC.ClickedExit += CloseForm;
        }

        private void toolStripMenuItemPlantTypes_Click(object sender, EventArgs e)
        {
            var plantTypeAdminUC = new UserControlPlantTypeAdmin() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(plantTypeAdminUC);
            plantTypeAdminUC.ClickedExit += CloseForm;
        }

        private void toolStripMenuItemLocations_Click(object sender, EventArgs e)
        {
            var locationAdminUC = new UserControlLocationAdmin() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(locationAdminUC);
            locationAdminUC.ClickedExit += CloseForm;
        }

        private void toolStripMenuItemActionTypes_Click(object sender, EventArgs e)
        {
            var actionTypeAdminUC = new UserControlActionTypeAdmin() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(actionTypeAdminUC);
            actionTypeAdminUC.ClickedExit += CloseForm;
        }

        private void toolStripMenuItemPlantTypesPerLocation_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var plantTypesPerLocationOverview = new UserControlPlantsPerLocationOverview(OverviewTypes.PlantTypes) { Dock = DockStyle.Fill };
            panel1.Controls.Add(plantTypesPerLocationOverview);
        }

        private void toolStripMenuItemPlantsPerLocation_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var plantTypesPerLocationOverview = new UserControlPlantsPerLocationOverview(OverviewTypes.Plants) { Dock = DockStyle.Fill };
            panel1.Controls.Add(plantTypesPerLocationOverview);

        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            CloseForm(sender, e);
        }

        private void toolStripMenuItemViewHelp_Click(object sender, EventArgs e)
        {
            using (FormViewHelp formviewHelp = new FormViewHelp())
            {
                formviewHelp.ShowDialog();
            }
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout formAbout = new FormAbout())
            {
                formAbout.ShowDialog();
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            panel1.Parent.Focus();
        }
    }
}
