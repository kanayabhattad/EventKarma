using FluentNHibernate.Mapping;
using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class ApplicationPropertiesMap : ClassMap<ApplicationProperties>
    {
        public ApplicationPropertiesMap()
        {
            Table("application_properties");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Property).Column("property").Not.Nullable();
            Map(x => x.Value).Column("value");
            Map(x => x.Category).Column("category").Not.Nullable();
            Map(x => x.IsEncrypted).Column("is_encrypted").Not.Nullable();
            Map(x => x.ProgramCode).Column("program_code");
            Map(x => x.AppId).Column("app_id");
        }
    }
}
