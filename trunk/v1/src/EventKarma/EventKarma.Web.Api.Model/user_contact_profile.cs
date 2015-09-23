//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class UserContactProfile : IAuditModel
    {
        public  int Userid { get; set; }
        public  string Email { get; set; }
        public  string LandLineNumber { get; set; }
        public  string MobileNumberPrimary { get; set; }
        public  string MobileNumberSecondary { get; set; }
        public  string Fax { get; set; }
        public  string Address { get; set; }
        public  string Country { get; set; }
        public  string City { get; set; }
        public  string State { get; set; }
        public  string Zip { get; set; }
        public  string SuiteOrApt { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }

        public  User User { get; set; }
    }
}
