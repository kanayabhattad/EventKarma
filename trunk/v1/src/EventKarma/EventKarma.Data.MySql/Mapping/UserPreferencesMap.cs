using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class UserPreferencesMap : AuditClassMap<UserPreferences>
    {
        public UserPreferencesMap()
        {
            Table("user_preferences");
            LazyLoad();
            Id(x => x.UserId).GeneratedBy.Identity().Column("user_id");
            References(x => x.LocaleMaster).Column("locale_id");
            References(x => x.TimezoneMaster).Column("timezone_id");
            Map(x => x.Id).Column("id").Not.Nullable();

        }
    }
}
