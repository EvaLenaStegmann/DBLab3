using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyGarden
{
    [DebuggerDisplay("{Namn}")]
    public partial class Växttyp
    {
        public int Id { get; set; }
        public string Namn { get; set; }

        //        public virtual ICollection<Order> Orders { get; set; }

        public Växttyp()
        {
//            Orders = new HashSet<Order>();
        }
    }
}
