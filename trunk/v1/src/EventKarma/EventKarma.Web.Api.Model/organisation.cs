//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class Organisation : IAuditModel
    {
        public  int Id { get; set; }
        public  string OrganisationName { get; set; }
        public  string OrganizationCode { get; set; }
        public  int? OrganizationOwnerId { get; set; }
        public  int? UserAuthenticationTypeId { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  bool? IsDeleted { get; set; }
    }
}
