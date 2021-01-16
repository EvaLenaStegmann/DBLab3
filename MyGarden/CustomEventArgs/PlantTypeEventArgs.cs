using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarden
{
    public class PlantTypeEventArgs
    {
        public PlantType plantType { get; set; }

        public PlantTypeEventArgs(PlantType plantType)
        {
            this.plantType = plantType;
        }
    }
}
