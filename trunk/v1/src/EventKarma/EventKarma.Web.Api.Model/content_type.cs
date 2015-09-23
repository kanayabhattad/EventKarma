//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class ContentType
    {

        public  int Id { get; set; }
        public  string ContentDisplayName { get; set; }
        public  int? ContentNotes { get; set; }
        public  string ContentTypeval { get; set; }

        public  ICollection<Content> Contents { get; set; }
    }
}
