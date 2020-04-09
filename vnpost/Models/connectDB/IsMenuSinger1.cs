using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsMenuSinger1
    {
        public IsMenuSinger1()
        {
            InverseBoNNavigation = new HashSet<IsMenuSinger1>();
            IsAdminMenuId1Navigation = new HashSet<IsAdmin>();
            IsAdminMenuId2Navigation = new HashSet<IsAdmin>();
            IsAdminMenuId3Navigation = new HashSet<IsAdmin>();
        }

        public int MenuId { get; set; }
        public int? ThemeId { get; set; }
        public int? Stt { get; set; }
        public int? BoN { get; set; }

        public virtual IsMenuSinger1 BoNNavigation { get; set; }
        public virtual IsTheme Theme { get; set; }
        public virtual ICollection<IsMenuSinger1> InverseBoNNavigation { get; set; }
        public virtual ICollection<IsAdmin> IsAdminMenuId1Navigation { get; set; }
        public virtual ICollection<IsAdmin> IsAdminMenuId2Navigation { get; set; }
        public virtual ICollection<IsAdmin> IsAdminMenuId3Navigation { get; set; }
    }
}
