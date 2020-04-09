using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsSpecies
    {
        public IsSpecies()
        {
            InverseThemeDabNavigation = new HashSet<IsSpecies>();
            IsPost = new HashSet<IsPost>();
            IsVideo = new HashSet<IsVideo>();
        }

        public int SpeciesId { get; set; }
        public string Isname { get; set; }
        public string IsTitle { get; set; }
        public string AvatarSpecies { get; set; }
        public bool Deleted { get; set; }
        public int? ThemeId { get; set; }
        public int? ThemeDab { get; set; }

        public virtual IsTheme Theme { get; set; }
        public virtual IsSpecies ThemeDabNavigation { get; set; }
        public virtual ICollection<IsSpecies> InverseThemeDabNavigation { get; set; }
        public virtual ICollection<IsPost> IsPost { get; set; }
        public virtual ICollection<IsVideo> IsVideo { get; set; }
    }
}
