using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class UserMap : AuditClassMap<User>
    {
        public UserMap()
        {
            Table("user");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Username).Column("username").Not.Nullable();
            Map(x => x.Hashpassword).Column("hashpassword").Not.Nullable();
            Map(x => x.HashToken).Column("hash_token");
            Map(x => x.HashTokenExpiration).Column("hash_token_expiration");
            Map(x => x.SecretQuestion).Column("secret_question");
            Map(x => x.TermsOfServiceAgreed).Column("terms_of_service_agreed");
            Map(x => x.SecretAnswer).Column("secret_answer");
            Map(x => x.StatusId).Column("status_id").Not.Nullable();
            Map(x => x.AvailabilityStatus).Column("availability_status");
            Map(x => x.LastLoginDate).Column("last_login_date");
            Map(x => x.OptIn).Column("opt_in");
            Map(x => x.LoginAttempt).Column("login_attempt");
            Map(x => x.LockLoginTime).Column("lock_login_time");
            Map(x => x.IsLoggedin).Column("is_loggedin");
        }
    }
}
