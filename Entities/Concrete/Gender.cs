using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Gender : BaseEntity
    {
        public string Description { get; set; }
        
        #region Navigation Property
        public List<Users> User { get; set; } 
        #endregion
    }
}
