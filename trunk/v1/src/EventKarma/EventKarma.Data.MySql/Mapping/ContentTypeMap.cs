using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class ContentTypeMap : ClassMap<ContentType>
    {
        public ContentTypeMap()
        {
            Table("content_type");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.ContentDisplayName).Column("content_display_name").Not.Nullable();
            Map(x => x.ContentNotes).Column("content_notes");
            Map(x => x.ContentTypeval).Column("content_type").Not.Nullable();
        }
    }
}
