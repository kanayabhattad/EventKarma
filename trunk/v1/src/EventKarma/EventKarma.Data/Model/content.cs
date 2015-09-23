//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class Content : IAuditModel
    {
        public virtual int Id { get; set; }
        public virtual ContentType ContentType { get; set; }
        public virtual User User { get; set; }
        public virtual Source Source { get; set; }
        public virtual string Contentval { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }

        public virtual ICollection<TagContentMapping> TagContentMapping { get; set; }



    }
}
