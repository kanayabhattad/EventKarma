//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class FunctionMaster
    {

        public virtual int Id { get; set; }
        public virtual ApplicationTypeMaster ApplicationTypeMaster { get; set; }
        public virtual string FunctionName { get; set; }


        public virtual ICollection<UsertypeFunctionMapping> UsertypeFunctionMapping { get; set; }
    }
}
