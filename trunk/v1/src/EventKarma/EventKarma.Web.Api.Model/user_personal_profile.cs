//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class UserPersonalProfile : IAuditModel
    {
        public  int Userid { get; set; }
        public  string Gender { get; set; }
        public  string Company { get; set; }
        public  string ProfilePictureLink { get; set; }
        public  string Title { get; set; }
        public  int? BirthDate { get; set; }
        public  int? Age { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string MiddleName { get; set; }
        public  string DisplayName { get; set; }
        public  string Nickname { get; set; }
        public  string AboutMe { get; set; }
        public  string IsFeatured { get; set; }
        public  string Credentials { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }

        public  User user { get; set; }
    }
}
