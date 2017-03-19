using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Boats
    {
        public Boats()
        {
            Teams = new HashSet<Teams>();
        }

        public int Id { get; set; }
        public int SailingNo { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Handicap { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Teams> Teams { get; set; }
    }
}
