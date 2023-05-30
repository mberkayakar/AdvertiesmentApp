using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AppRole : BaseEntity
    {
        public string Definition { get; set; } // Yetki açıklaması
        
        #region Navigation Property
        public List<AppUsersRoles> UsersRoles { get; set; }
        #endregion
    }
}
