using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsAdmin
    {
        public int AdminId { get; set; }
        public int? MenuId1 { get; set; }
        public string Logo { get; set; }
        public int? MenuId2 { get; set; }
        public int? MenuId3 { get; set; }
        public int? MenuId { get; set; }
        public string Footer { get; set; }

        public virtual ThanTrang Menu { get; set; }
        public virtual IsMenuSinger1 MenuId1Navigation { get; set; }
        public virtual IsMenuSinger1 MenuId2Navigation { get; set; }
        public virtual IsMenuSinger1 MenuId3Navigation { get; set; }
    }
}
