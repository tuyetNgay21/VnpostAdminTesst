﻿using System;
using System.Collections.Generic;

namespace vnpost.Models.connectDB
{
    public partial class IsPost
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime DayInPost { get; set; }
        public string AvataIndex { get; set; }
        public string Content { get; set; }
        public int? ViewPost { get; set; }
        public bool Deleted { get; set; }
        public int? SpeciesId { get; set; }

        public virtual IsSpecies Species { get; set; }
    }
}
