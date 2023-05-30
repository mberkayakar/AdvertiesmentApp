using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AdvertiesmentUser : BaseEntity
    {
        public int UserId { get; set; }
        public bool Status { get; set; }    
        public int AdvertiesmentUserStatusId { get; set; }  
        public int MilitaryStatusId { get; set; }
        public DateTime? MilitaryStatusDate { get; set; }
        public int WorkExperience { get; set; } // Calisma deneyimi Yil bazinda 
        public string CvPath { get; set; }

        #region Navigation Property
        public Users User { get; set; }
        public Advertisement Advertisement { get; set; }
        public MilitaryStatus MilitaryStatus { get; set; } 
        public AdvertiesmentUserStatus advertiesmentUser { get; set; }
        #endregion
    }
}
