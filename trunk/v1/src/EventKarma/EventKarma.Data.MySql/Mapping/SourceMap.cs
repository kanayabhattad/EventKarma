using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class SourceMap:AuditClassMap<Source>
    {
        public SourceMap()
        {
            Table("source");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.SourceType).Column("source_type_id");
            Map(x => x.SourceDescription).Column("source_description").Not.Nullable();
            Map(x => x.UserId).Column("user_id").Not.Nullable();
            Map(x => x.SourceName).Column("source_name").Not.Nullable();
        }
    }
}
