using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class ContentMap : AuditClassMap<Content>
    {
        public ContentMap()
        {
            Table("content");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.ContentType).Column("content_type_id");
            References(x => x.User).Column("user_id");
            References(x => x.Source).Column("source_id");
            Map(x => x.Contentval).Column("content").Not.Nullable();

        }
    }
}
