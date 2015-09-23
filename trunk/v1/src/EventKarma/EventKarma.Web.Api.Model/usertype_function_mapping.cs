//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class UsertypeFunctionMapping : IAuditModel
    {
        public  int UsertypeId { get; set; }
        public  int FunctionId { get; set; }
        public  int CreatedBy { get; set; }
        public  int? UpdatedBy { get; set; }
        public  long CreatedOn { get; set; }
        public  long? UpdatedOn { get; set; }
        public  bool? IsDeleted { get; set; }
        public  int Id { get; set; }

    }
}
