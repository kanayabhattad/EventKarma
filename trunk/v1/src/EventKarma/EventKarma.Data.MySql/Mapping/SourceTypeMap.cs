using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class SourceTypeMap:ClassMap<SourceType>
    {
        public SourceTypeMap()
        {
            Table("source_type");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.SourceTypeval).Column("source_type");
            Map(x => x.SourceDisplayName).Column("source_display_name").Not.Nullable();
            Map(x => x.SourceNotes).Column("source_notes");
        }
    }
}
