using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public class Album
    {
        public string AlbumName { get; set; }
        public string GenreId { get; set; }
        public string AuthorId { get; set; }
    }
}
