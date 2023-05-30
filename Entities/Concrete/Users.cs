using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Users : BaseEntity // User tablosu 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }   

        #region Role
        public List<AppUsersRoles> Roles { get; set; }
        public List<AdvertiesmentUser> AdvertiesmentUsers { get; set; }
        public Gender Gender { get; set; }
        #endregion
    }
}
