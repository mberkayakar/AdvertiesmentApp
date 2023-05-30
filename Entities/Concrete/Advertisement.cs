using System;
using System.Collections.Generic;
using System.Reflection;

namespace Entities.Concrete
{
    public class Advertisement : BaseEntity
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        #region Navigation Property
        public List<AdvertiesmentUser> AdvertiesmentUsers { get; set; } 
        #endregion
    }
}
