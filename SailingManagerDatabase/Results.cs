using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Results
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int TeamId { get; set; }
        public int Rank { get; set; }
        public double ActualDistance { get; set; }
        public double CalculatedDistance { get; set; }
        public DateTime ActualTime { get; set; }
        public DateTime CalculatedTime { get; set; }
        public double Penalty { get; set; }

        public virtual Races Race { get; set; }
        public virtual Teams Team { get; set; }
    }
}
