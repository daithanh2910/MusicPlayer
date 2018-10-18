using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public interface IEntity
    {
        bool? Deleted { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public abstract class BaseEntity : Entity { }
}
