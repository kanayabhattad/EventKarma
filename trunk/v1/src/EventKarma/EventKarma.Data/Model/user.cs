//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class User : IAuditModel
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Hashpassword { get; set; }
        public virtual string HashToken { get; set; }
        public virtual int? HashTokenExpiration { get; set; }
        public virtual string SecretQuestion { get; set; }
        public virtual string TermsOfServiceAgreed { get; set; }
        public virtual string SecretAnswer { get; set; }
        public virtual int StatusId { get; set; }
        public virtual string AvailabilityStatus { get; set; }
        public virtual int? LastLoginDate { get; set; }
        public virtual string OptIn { get; set; }
        public virtual int? LoginAttempt { get; set; }
        public virtual int? LockLoginTime { get; set; }
        public virtual string IsLoggedin { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }

        public virtual ICollection<Content> Contents { get; set; }
        public virtual UserContactProfile UserContactProfile { get; set; }
        public virtual ICollection<UserPreferencesMapping> UserPreferencesMapping { get; set; }
        public virtual UserPersonalProfile UserPersonalProfile { get; set; }
        public virtual ICollection<UserUsertypeMapping> UserUsertypeMapping { get; set; }
        public virtual UserPreferences UserPreferences { get; set; }
    }
}
