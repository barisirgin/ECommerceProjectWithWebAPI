using Entities.Abstract;

namespace Entities.Concreate.BaseEntities
{
    public class AuditableEntity : BaseEntity, ICreatedEntity,IUpdatedEntity
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDate { get; set; }
        int? UpdatedUserId { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}
