
using Entities.Abstract;

namespace Entities.Concreate.BaseEntities
{
    public interface BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
