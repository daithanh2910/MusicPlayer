using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public class Album : BaseEntity
    {
        public string AlbumName { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
