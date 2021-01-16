using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarden
{
    public class PlantEventArgs
    {
        public Plant plant { get; set; }
        public PlantEventArgs(Plant plant)
        {
            this.plant = plant;
        }
    }
}
