using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class CountriesMasterMap : ClassMap<CountriesMaster>
    {
        public CountriesMasterMap()
        {
            Table("countries_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.CountryCode).Column("country_code").Not.Nullable();
            Map(x => x.CountryName).Column("country_name").Not.Nullable();
        }
    }
}
