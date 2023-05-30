namespace Entities.Concrete
{
    public class AppUsersRoles : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        
        #region Navigation Property
        public Users Users { get; set; }
        public AppRole Role { get; set; }
        #endregion

    }
}
