using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class TagContentMappingMap : ClassMap<TagContentMapping>
    {
        public TagContentMappingMap()
        {
            Table("tag_content_mapping");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.Tag).Column("tag_id");
            References(x => x.Content).Column("content_id");
        }
    }
}
