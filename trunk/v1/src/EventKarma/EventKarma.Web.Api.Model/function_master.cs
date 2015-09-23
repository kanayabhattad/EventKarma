//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class FunctionMaster
    {

        public  int Id { get; set; }
        public  ApplicationTypeMaster ApplicationTypeMaster { get; set; }
        public  string FunctionName { get; set; }


        public  ICollection<UsertypeFunctionMapping> UsertypeFunctionMapping { get; set; }
    }
}
