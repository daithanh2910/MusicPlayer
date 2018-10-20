using System.Collections.Generic;

namespace Repository.Entities
{
    public class Album : BaseEntity
    {
        public string AlbumName { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<SongAlbum> SongAlbums { get; set; }
    }
}
