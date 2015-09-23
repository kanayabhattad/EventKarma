//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class UserUsertypeMapping : IAuditModel
    {
        public virtual int Id { get; set; }
        public virtual User User { get; set; }
        public virtual UsertypeMaster UsertypeMaster { get; set; }
        public virtual int? OrgId { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }

    }
}
