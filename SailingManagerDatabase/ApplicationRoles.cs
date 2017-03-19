using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class ApplicationRoles
    {
        public ApplicationRoles()
        {
            UserApplicationRoles = new HashSet<UserApplicationRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserApplicationRoles> UserApplicationRoles { get; set; }
    }
}
