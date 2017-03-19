using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Races
    {
        public Races()
        {
            Results = new HashSet<Results>();
        }

        public int Id { get; set; }
        public int RegattaId { get; set; }
        public int EventNo { get; set; }
        public string EndLocation { get; set; }
        public string Classification { get; set; }
        public int? MaxTeams { get; set; }
        public double MinHandicap { get; set; }
        public double MaxHandicap { get; set; }

        public virtual ICollection<Results> Results { get; set; }
        public virtual Events EventNoNavigation { get; set; }
        public virtual Regattas Regatta { get; set; }
    }
}
