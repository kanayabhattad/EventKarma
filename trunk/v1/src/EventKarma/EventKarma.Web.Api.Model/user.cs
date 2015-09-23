//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class User : IAuditModel
    {
        public  int Id { get; set; }
        public  string Username { get; set; }
        public  string Hashpassword { get; set; }
        public  string HashToken { get; set; }
        public  int? HashTokenExpiration { get; set; }
        public  string SecretQuestion { get; set; }
        public  string TermsOfServiceAgreed { get; set; }
        public  string SecretAnswer { get; set; }
        public  int StatusId { get; set; }
        public  string AvailabilityStatus { get; set; }
        public  int? LastLoginDate { get; set; }
        public  string OptIn { get; set; }
        public  int? LoginAttempt { get; set; }
        public  int? LockLoginTime { get; set; }
        public  string IsLoggedin { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }

        public  ICollection<Content> Contents { get; set; }
        public  UserContactProfile UserContactProfile { get; set; }
        public  ICollection<UserPreferencesMapping> UserPreferencesMapping { get; set; }
        public  UserPersonalProfile UserPersonalProfile { get; set; }
        public  ICollection<UserUsertypeMapping> UserUsertypeMapping { get; set; }
        public  UserPreferences UserPreferences { get; set; }
    }
}
