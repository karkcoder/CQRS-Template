using Domain.Commons;

namespace Domain.Entities
{
    public class Product : AuditEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
    }
}