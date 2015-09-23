//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class SourceType
    {
       
        public virtual int Id { get; set; }
        public virtual string SourceTypeval { get; set; }
        public virtual string SourceDisplayName { get; set; }
        public virtual string SourceNotes { get; set; }

        public virtual ICollection<Source> Sources { get; set; }
    }
}
