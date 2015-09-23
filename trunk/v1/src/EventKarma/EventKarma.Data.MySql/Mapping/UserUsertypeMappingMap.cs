using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class UserUsertypeMappingMap : AuditClassMap<UserUsertypeMapping>
    {
        public UserUsertypeMappingMap()
        {
            Table("user_usertype_mapping");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.User).Column("user_id");
            References(x => x.UsertypeMaster).Column("usertype_id");
            Map(x => x.OrgId).Column("org_id");
        }
    }
}
