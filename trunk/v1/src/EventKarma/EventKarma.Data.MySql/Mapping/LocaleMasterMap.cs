using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class LocaleMasterMap : ClassMap<LocaleMaster>
    {
        public LocaleMasterMap()
        {
            Table("locale_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.LocaleDescription).Column("locale_description");
            Map(x => x.Locale).Column("locale");
        }
    }
}
