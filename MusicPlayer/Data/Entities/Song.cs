using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public class Song : BaseEntity
    {
        public string SongName { get; set; }
        public string PathSong { get; set; }
        public int UserId { get; set; }
        public int SingerId { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }

        public virtual Author Author { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Singer Singer { get; set; }
        public virtual ICollection<SongAlbum> SongAlbums { get; set; }
    }
}
