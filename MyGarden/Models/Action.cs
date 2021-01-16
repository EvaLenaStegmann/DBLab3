using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyGarden
{
    [DebuggerDisplay("{Plant.Name}, {Location.Name}, {ActionDate}")]
    public class Action
    {
        public int PlantId { get; set; }
        public int LocationId { get; set; }
        public int Id { get; set; }
        public int ActionTypeId { get; set; }
        public DateTime ActionDate { get; set; }
        public short HarvestSeason { get; set; }

        public virtual Plant Plant { get; set; }
        public virtual Location Location { get; set; }
        public virtual ActionType ActionType { get; set; }

         public Action()
        {
        }
    }
}
