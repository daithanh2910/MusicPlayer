using System.Collections.Generic;

namespace Repository.Entities
{
    public class Genre : BaseEntity
    {
        public string GenreName { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
