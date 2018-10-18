using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public class Author : BaseEntity
    {
        public string AuthorName { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
