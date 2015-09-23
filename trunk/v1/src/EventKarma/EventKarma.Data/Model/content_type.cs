//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class ContentType
    {

        public virtual int Id { get; set; }
        public virtual string ContentDisplayName { get; set; }
        public virtual int? ContentNotes { get; set; }
        public virtual string ContentTypeval { get; set; }

        public virtual ICollection<Content> Contents { get; set; }
    }
}
