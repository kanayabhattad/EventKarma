using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class StatusMasterMap:ClassMap<StatusMaster>
    {
        public StatusMasterMap()
        {
            Table("status_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.StatusType).Column("status_type").Not.Nullable();
        }
    }
}
