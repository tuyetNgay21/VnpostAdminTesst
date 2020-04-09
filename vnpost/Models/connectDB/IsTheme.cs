using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsTheme
    {
        public IsTheme()
        {
            IsMenuSinger1 = new HashSet<IsMenuSinger1>();
            IsSpecies = new HashSet<IsSpecies>();
        }

        public int ThemeId { get; set; }
        public string Isname { get; set; }
        public string IsTitle { get; set; }
        public bool Deleted { get; set; }
        public string AvatarTheme { get; set; }

        public virtual ICollection<IsMenuSinger1> IsMenuSinger1 { get; set; }
        public virtual ICollection<IsSpecies> IsSpecies { get; set; }
    }
}
