using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class UsertypeFunctionMappingMap : AuditClassMap<UsertypeFunctionMapping>
    {
        public UsertypeFunctionMappingMap()
        {
            Table("usertype_function_mapping");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.UsertypeId).Column("usertype_id");
            References(x => x.FunctionId).Column("function_id");
        }

    }
}
