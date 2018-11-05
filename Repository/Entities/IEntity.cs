using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
    public interface IEntity
    {
        bool? Deleted { get; set; }
        Guid UniqueId { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public Guid UniqueId { get; set; } = Guid.NewGuid();
        public bool? Deleted { get; set; }
        [DefaultDateTimeValue("Now")]
        public DateTime CreatedDate { get; set; }
        [DefaultDateTimeValue("Now")]
        public DateTime ModifiedDate { get; set; }
    }

    public abstract class BaseEntity : Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }
    }
}
