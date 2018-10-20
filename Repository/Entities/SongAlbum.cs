using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class SongAlbum : Entity
    {
        [Key]
        public int SongId { get; set; }
        [Key]
        public int AlbumId { get; set; }
        public virtual Song Song { get; set; }
        public virtual Album Album { get; set; }
    }
}
