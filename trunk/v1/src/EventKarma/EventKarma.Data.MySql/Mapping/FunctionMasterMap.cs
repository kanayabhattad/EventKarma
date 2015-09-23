using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class FunctionMasterMap : ClassMap<FunctionMaster>
    {
        public FunctionMasterMap()
        {
            Table("function_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.ApplicationTypeMaster).Column("application_type");
            Map(x => x.FunctionName).Column("function_name").Not.Nullable();
        }
    }
}
