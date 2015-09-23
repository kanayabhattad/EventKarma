//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class Content : IAuditModel
    {
        public  int Id { get; set; }
        public  ContentType ContentType { get; set; }
        public  User User { get; set; }
        public  Source Source { get; set; }
        public  string Contentval { get; set; }
        public  int CreatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }

        public  ICollection<TagContentMapping> TagContentMapping { get; set; }



    }
}
