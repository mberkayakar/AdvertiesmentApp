using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AdvertiesmentUserStatus : BaseEntity
    {
        public string Definition { get; set; }
        
        #region Navigation Property
        public List<AdvertiesmentUser> advertiesmentUser { get; set; }    
        #endregion
    }
}
