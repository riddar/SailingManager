using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Entries
    {
        public Entries()
        {
            RegisteredEntryUsers = new HashSet<RegisteredEntryUsers>();
            Teams = new HashSet<Teams>();
        }

        public int Id { get; set; }
        public int No { get; set; }
        public int? PaidFee { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int ResponsibleUserId { get; set; }
        public int RegattaId { get; set; }

        public virtual ICollection<RegisteredEntryUsers> RegisteredEntryUsers { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
        public virtual Regattas Regatta { get; set; }
        public virtual Users ResponsibleUser { get; set; }
    }
}
