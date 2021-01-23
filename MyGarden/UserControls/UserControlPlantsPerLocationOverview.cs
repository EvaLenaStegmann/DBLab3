using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace MyGarden
{
    public enum OverviewTypes
    {
        Plants,
        PlantTypes
    }

    public partial class UserControlPlantsPerLocationOverview : UserControl
    {
        public OverviewTypes OverviewType { get; set; }
        private ICollection<Location> Locations { get; set; }

        private List<PlantsPerLocation> plantsPerLocationList;

        private List<PlantsPerLocation> PlantsPerLocationList
        {
            get
            {
                return plantsPerLocationList;
            }
            set
            {
                plantsPerLocationList = value;
                LoadDataGrid();
            }
        }

        public UserControlPlantsPerLocationOverview(OverviewTypes overviewTypes)
        {
            InitializeComponent();
            OverviewType = overviewTypes;
        }

        private void UserControlPlantTypesPerLocationOverview_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MyGardenContext())
                {
                    if (db.Database.CanConnect())
                    {
                        Locations = db.Locations.ToList();

                        string query;
                        if (OverviewType == OverviewTypes.PlantTypes)
                        {
                            query = "select * from PlantTypesPerLocation order by HarvestSeason desc;";
                        }
                        else
                        {
                            query = "select * from PlantsPerLocation order by HarvestSeason desc;";
                        }
                        PlantsPerLocationList = db.PlantsPerLocation.FromSqlRaw(query).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGrid()
        {
            dataGridViewPlantTypesPerLocation.Columns.Clear();
            dataGridViewPlantTypesPerLocation.Rows.Clear();

            dataGridViewPlantTypesPerLocation.Columns.Add("HarvestSeason", "Harvest Season:");
            dataGridViewPlantTypesPerLocation.Columns["HarvestSeason"].Width = 70;
            dataGridViewPlantTypesPerLocation.Columns["HarvestSeason"].Resizable = DataGridViewTriState.False;
            dataGridViewPlantTypesPerLocation.Columns["HarvestSeason"].Frozen = true;
            dataGridViewPlantTypesPerLocation.Columns["HarvestSeason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dataGridViewPlantTypesPerLocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (Location location in Locations)
            {
                dataGridViewPlantTypesPerLocation.Columns.Add(location.Name, location.Name + ":");
                dataGridViewPlantTypesPerLocation.Columns[location.Name].MinimumWidth = 140;
            }

            if (PlantsPerLocationList.Count == 0)
            {
                return;
            }

            int i = 0;
            do
            {
                int harvestSeason = PlantsPerLocationList[i].HarvestSeason;
                int rowIndex = dataGridViewPlantTypesPerLocation.Rows.Add();

                dataGridViewPlantTypesPerLocation.Rows[rowIndex].Cells["HarvestSeason"].Value = PlantsPerLocationList[i].HarvestSeason;
                do
                {
                    dataGridViewPlantTypesPerLocation.Rows[rowIndex].Cells[PlantsPerLocationList[i].LocationName].Value = PlantsPerLocationList[i].PlantNames;
                    i++;

                } while (i < PlantsPerLocationList.Count && PlantsPerLocationList[i].HarvestSeason == harvestSeason);

            } while (i < PlantsPerLocationList.Count);
        }
    }
}
