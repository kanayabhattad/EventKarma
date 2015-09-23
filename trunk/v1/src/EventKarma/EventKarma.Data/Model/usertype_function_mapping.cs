//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class UsertypeFunctionMapping : IAuditModel
    {
        public virtual User UsertypeId { get; set; }
        public virtual FunctionMaster FunctionId { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual long CreatedOn { get; set; }
        public virtual long? UpdatedOn { get; set; }
        public virtual bool? IsDeleted { get; set; }
        public virtual int Id { get; set; }

    }
}
