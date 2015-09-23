//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class UserPersonalProfile : IAuditModel
    {
        public virtual int Userid { get; set; }
        public virtual string Gender { get; set; }
        public virtual string Company { get; set; }
        public virtual string ProfilePictureLink { get; set; }
        public virtual string Title { get; set; }
        public virtual int? BirthDate { get; set; }
        public virtual int? Age { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Nickname { get; set; }
        public virtual string AboutMe { get; set; }
        public virtual string IsFeatured { get; set; }
        public virtual string Credentials { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }

        public virtual User user { get; set; }
    }
}
