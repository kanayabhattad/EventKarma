//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public class TagContentMapping
    {
        public virtual int Id { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Content Content { get; set; }

    }
}
