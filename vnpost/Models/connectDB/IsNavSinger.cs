using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsNavSinger
    {
        public IsNavSinger()
        {
            IsNavbar = new HashSet<IsNavbar>();
        }

        public int NavbarSingerId { get; set; }
        public string Title { get; set; }
        public string ImageSinger { get; set; }
        public string LinkImage { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime DateDelete { get; set; }

        public virtual ICollection<IsNavbar> IsNavbar { get; set; }
    }
}
