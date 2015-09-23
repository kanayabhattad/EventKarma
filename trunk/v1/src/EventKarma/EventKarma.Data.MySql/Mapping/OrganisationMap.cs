using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class OrganisationMap:AuditClassMap<Organisation>
    {
        public OrganisationMap()
        {
            Table("organisation");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.OrganisationName).Column("organisation_name").Not.Nullable();
            Map(x => x.OrganizationCode).Column("organization_code").Not.Nullable();
            Map(x => x.OrganizationOwnerId).Column("organization_owner_id");
            Map(x => x.UserAuthenticationTypeId).Column("user_authentication_type_id");
        }
    }
}
