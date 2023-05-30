using System.Collections.Generic;

namespace Entities.Concrete
{
    public class MilitaryStatus : BaseEntity
    {
        public string Definition { get; set; }

        #region Navigation Property
        public List<AdvertiesmentUser> AdvertiesmentUser { get; set; }
        #endregion

    }
}
