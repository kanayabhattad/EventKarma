//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class Source : IAuditModel
    {

        public virtual int Id { get; set; }
        public virtual SourceType SourceType { get; set; }
        public virtual string SourceDescription { get; set; }
        public virtual int UserId { get; set; }
        public virtual string SourceName { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual bool? IsDeleted { get; set; }

        public virtual ICollection<Content> Contents { get; set; }

    }
}
