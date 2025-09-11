namespace SbTemplate.Core.Entities.BaseEntity
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
