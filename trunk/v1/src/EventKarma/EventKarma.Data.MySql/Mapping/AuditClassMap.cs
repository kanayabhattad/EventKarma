using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public abstract class AuditClassMap<T> : ClassMap<T> where T : IAuditModel
    {
        protected AuditClassMap()
        {
            Map(x => x.CreatedBy).Column("created_by").Not.Nullable();
            Map(x => x.CreatedOn).Column("created_on").Not.Nullable();
            Map(x => x.UpdatedBy).Column("updated_by").Not.Nullable();
            Map(x => x.UpdatedOn).Column("updated_on").Not.Nullable();
            Map(x => x.IsDeleted).Column("is_deleted").Not.Nullable();
        }
    }
}
