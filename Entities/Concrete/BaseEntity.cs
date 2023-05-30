using Entities.Abstract;

namespace Entities.Concrete
{
    public class BaseEntity : IEntities
    {
        public int Id { get; set; } // PK 
    }
}
