using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyGarden
{
    [DebuggerDisplay("{Name}")]
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlantTypeId { get; set; }

        public virtual PlantType PlantType { get; set; }

        public virtual ICollection<Action> Actions { get; set; }

        public Plant()
        {
            Actions = new HashSet<Action>();
        }

        public object This { get { return this; } }

        public override string ToString()
        {
            return Name;
        }
    }
}
