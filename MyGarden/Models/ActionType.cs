using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyGarden
{
    [DebuggerDisplay("{Name}")]
    public class ActionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
 
        public virtual ICollection<Action> Actions { get; set; }

        public ActionType()
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
