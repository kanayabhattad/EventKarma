//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class Tag : IAuditModel
    {
        public  int Id { get; set; }
        public  string TagName { get; set; }
        public  string TagNote { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }

        public  ICollection<TagContentMapping> TagContentMapping { get; set; }
    }
}
