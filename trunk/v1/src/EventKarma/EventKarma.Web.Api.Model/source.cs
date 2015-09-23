//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class Source : IAuditModel
    {

        public  int Id { get; set; }
        public  SourceType SourceType { get; set; }
        public  string SourceDescription { get; set; }
        public  int UserId { get; set; }
        public  string SourceName { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  bool? IsDeleted { get; set; }

        public  ICollection<Content> Contents { get; set; }

    }
}
