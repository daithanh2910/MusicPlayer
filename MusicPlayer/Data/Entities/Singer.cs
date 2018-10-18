﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public class Singer : BaseEntity
    {
        public string SingerName { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
