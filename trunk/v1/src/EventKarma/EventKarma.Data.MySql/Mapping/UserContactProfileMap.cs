using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class UserContactProfileMap:AuditClassMap<UserContactProfile>
    {
        public UserContactProfileMap()
        {
            Table("user_contact_profile");
            LazyLoad();
            Id(x => x.Userid).GeneratedBy.Identity().Column("userid");
            Map(x => x.Email).Column("email");
            Map(x => x.LandLineNumber).Column("land_line_number");
            Map(x => x.MobileNumberPrimary).Column("mobile_number_primary");
            Map(x => x.MobileNumberSecondary).Column("mobile_number_secondary");
            Map(x => x.Fax).Column("fax");
            Map(x => x.Address).Column("address");
            Map(x => x.Country).Column("country");
            Map(x => x.City).Column("city");
            Map(x => x.State).Column("state");
            Map(x => x.Zip).Column("zip");
            Map(x => x.SuiteOrApt).Column("suite_or_apt");
           
        }
    }
}
