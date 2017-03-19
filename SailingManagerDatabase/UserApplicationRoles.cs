using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class UserApplicationRoles
    {
        public int ApplicaitonRoleId { get; set; }
        public int UserId { get; set; }

        public virtual ApplicationRoles ApplicaitonRole { get; set; }
        public virtual Users User { get; set; }
    }
}
