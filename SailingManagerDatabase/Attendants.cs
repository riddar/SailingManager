using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Attendants
    {
        public int? Friends { get; set; }
        public int RegisteredEntryUserId { get; set; }
        public int SocialId { get; set; }

        public virtual RegisteredEntryUsers RegisteredEntryUser { get; set; }
        public virtual Socials Social { get; set; }
    }
}
