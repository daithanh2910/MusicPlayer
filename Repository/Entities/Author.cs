using System.Collections.Generic;

namespace Repository.Entities
{
    public class Author : BaseEntity
    {
        public string AuthorName { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
