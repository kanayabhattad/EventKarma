//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public class ApplicationProperties
    {
        public  int Id { get; set; }
        public  string Property { get; set; }
        public  string Value { get; set; }
        public  string Category { get; set; }
        public  string IsEncrypted { get; set; }
        public  string ProgramCode { get; set; }
        public  int? AppId { get; set; }
    }

}
