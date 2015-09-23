//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class UserPreferences : IAuditModel
    {
        public  int UserId { get; set; }
        public  LocaleMaster LocaleMaster { get; set; }
        public  TimezoneMaster TimezoneMaster { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  int Id { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }
        public  User User { get; set; }
    }
}
