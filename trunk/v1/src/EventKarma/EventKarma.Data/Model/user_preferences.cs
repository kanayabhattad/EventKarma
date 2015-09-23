//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class UserPreferences : IAuditModel
    {
        public virtual int UserId { get; set; }
        public virtual LocaleMaster LocaleMaster { get; set; }
        public virtual TimezoneMaster TimezoneMaster { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual int Id { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }
        public virtual User User { get; set; }
    }
}
