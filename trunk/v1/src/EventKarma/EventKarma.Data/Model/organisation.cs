//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class Organisation : IAuditModel
    {
        public virtual int Id { get; set; }
        public virtual string OrganisationName { get; set; }
        public virtual string OrganizationCode { get; set; }
        public virtual int? OrganizationOwnerId { get; set; }
        public virtual int? UserAuthenticationTypeId { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual bool? IsDeleted { get; set; }
    }
}
