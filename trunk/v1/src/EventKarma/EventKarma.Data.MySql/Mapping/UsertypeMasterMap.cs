using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class UsertypeMasterMap : ClassMap<UsertypeMaster>
    {
        public UsertypeMasterMap()
        {
            Table("usertype_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.UsertypeName).Column("usertype_name").Not.Nullable();
        }
    }
}
