using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Entities
{
    public class Comment : Entity
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int SongId { get; set; }
        public string Context { get; set; }
        public virtual User User { get; set; }
        public virtual Song Song { get; set; }
    }
}
