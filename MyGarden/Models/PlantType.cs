using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyGarden
{
    [DebuggerDisplay("{Name}")]
    public class PlantType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Perennial{ get; set; }
        public string? Soil{ get; set; }
        public string? Nutrition { get; set; }
        public string? Info { get; set; }
        
        public virtual ICollection<Plant> Plants { get; set; }

        public PlantType()
        {
            Plants = new HashSet<Plant>();
            Perennial = false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
