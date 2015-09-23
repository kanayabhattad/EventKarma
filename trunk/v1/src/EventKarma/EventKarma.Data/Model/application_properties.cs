//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public class ApplicationProperties
    {
        public virtual int Id { get; set; }
        public virtual string Property { get; set; }
        public virtual string Value { get; set; }
        public virtual string Category { get; set; }
        public virtual string IsEncrypted { get; set; }
        public virtual string ProgramCode { get; set; }
        public virtual int? AppId { get; set; }
    }

}
