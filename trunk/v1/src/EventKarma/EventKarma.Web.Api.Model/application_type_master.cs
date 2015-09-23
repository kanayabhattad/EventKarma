//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public  class ApplicationTypeMaster
    {
        public  int Id { get; set; }
        public  string AppType { get; set; }
        public  string AppVersion { get; set; }

        public  ICollection<FunctionMaster> FunctionMaster { get; set; }
    }
}
