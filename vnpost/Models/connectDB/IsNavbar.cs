using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsNavbar
    {
        public IsNavbar()
        {
            InverseBoNavBarNavigation = new HashSet<IsNavbar>();
        }

        public int NavbarId { get; set; }
        public int? NavbarSingerId { get; set; }
        public int? Stt { get; set; }
        public int? BoNavBar { get; set; }

        public virtual IsNavbar BoNavBarNavigation { get; set; }
        public virtual IsNavSinger NavbarSinger { get; set; }
        public virtual ICollection<IsNavbar> InverseBoNavBarNavigation { get; set; }
    }
}
