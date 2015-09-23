//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class UserContactProfile : IAuditModel
    {
        public virtual int Userid { get; set; }
        public virtual string Email { get; set; }
        public virtual string LandLineNumber { get; set; }
        public virtual string MobileNumberPrimary { get; set; }
        public virtual string MobileNumberSecondary { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Address { get; set; }
        public virtual string Country { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string SuiteOrApt { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}
