using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class TagMap : AuditClassMap<Tag>
    {
        public TagMap()
        {
            Table("tag");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.TagName).Column("tag_name").Not.Nullable();
            Map(x => x.TagNote).Column("tag_note");

        }
    }
}
