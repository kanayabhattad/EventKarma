//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class SourceType
    {
       
        public  int Id { get; set; }
        public  string SourceTypeval { get; set; }
        public  string SourceDisplayName { get; set; }
        public  string SourceNotes { get; set; }

        public  ICollection<Source> Sources { get; set; }
    }
}
