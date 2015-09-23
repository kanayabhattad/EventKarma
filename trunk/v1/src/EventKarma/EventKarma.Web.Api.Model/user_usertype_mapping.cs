//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class UserUsertypeMapping : IAuditModel
    {
        public  int Id { get; set; }
        public  User User { get; set; }
        public  UsertypeMaster UsertypeMaster { get; set; }
        public  int? OrgId { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }

    }
}
