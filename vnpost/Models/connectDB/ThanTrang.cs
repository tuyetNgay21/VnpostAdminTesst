using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class ThanTrang
    {
        public ThanTrang()
        {
            InverseBoNNavigation = new HashSet<ThanTrang>();
            IsAdmin = new HashSet<IsAdmin>();
        }

        public int MenuId { get; set; }
        public string PatialView { get; set; }
        public int? Stt { get; set; }
        public int? BoN { get; set; }

        public virtual ThanTrang BoNNavigation { get; set; }
        public virtual ICollection<ThanTrang> InverseBoNNavigation { get; set; }
        public virtual ICollection<IsAdmin> IsAdmin { get; set; }
    }
}
