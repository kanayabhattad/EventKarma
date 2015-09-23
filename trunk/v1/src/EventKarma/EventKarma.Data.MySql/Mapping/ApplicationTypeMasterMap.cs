using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class ApplicationTypeMasterMap : ClassMap<ApplicationTypeMaster>
    {
        public ApplicationTypeMasterMap()
        {
            Table("application_type_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.AppType).Column("app_type").Not.Nullable();
            Map(x => x.AppVersion).Column("app_version").Not.Nullable();
        }
    }
}
