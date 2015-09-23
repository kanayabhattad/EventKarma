using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class LanguageMasterMap : ClassMap<LanguageMaster>
    {
        public LanguageMasterMap()
        {
            Table("language_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.LanguageName).Column("language_name").Not.Nullable();
        }
    }
}
