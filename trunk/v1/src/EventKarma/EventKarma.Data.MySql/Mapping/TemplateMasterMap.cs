using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class TemplateMasterMap : ClassMap<TemplateMaster>
    {

        public TemplateMasterMap()
        {
            Table("template_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.TemplatePath).Column("template_path").Not.Nullable();
            Map(x => x.TemplateDescription).Column("template_description").Not.Nullable();
        }
    }
}
