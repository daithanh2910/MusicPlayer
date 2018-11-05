using System.Collections.Generic;

namespace Repository.Entities
{
    public class Album : BaseEntity
    {
        public string AlbumName { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int SingerId { get; set; }
        public virtual Genre Genre { get; set; }
        //public virtual Author Author { get; set; }
        public virtual Singer Singer { get; set; }
        public virtual ICollection<SongAlbum> SongAlbums { get; set; }
    }
}
