//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class Tag : IAuditModel
    {
        public virtual int Id { get; set; }
        public virtual string TagName { get; set; }
        public virtual string TagNote { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }

        public virtual ICollection<TagContentMapping> TagContentMapping { get; set; }
    }
}
