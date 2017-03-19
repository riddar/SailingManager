using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Teams
    {
        public Teams()
        {
            CrewMembers = new HashSet<CrewMembers>();
            Results = new HashSet<Results>();
        }

        public int Id { get; set; }
        public int EntryId { get; set; }
        public int BoatId { get; set; }
        public int SkipperUserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CrewMembers> CrewMembers { get; set; }
        public virtual ICollection<Results> Results { get; set; }
        public virtual Boats Boat { get; set; }
        public virtual Entries Entry { get; set; }
        public virtual RegisteredEntryUsers SkipperUser { get; set; }
    }
}
