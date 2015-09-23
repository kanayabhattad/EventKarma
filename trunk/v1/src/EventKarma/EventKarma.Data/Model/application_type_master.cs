//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public  class ApplicationTypeMaster
    {
        public virtual int Id { get; set; }
        public virtual string AppType { get; set; }
        public virtual string AppVersion { get; set; }

        public virtual ICollection<FunctionMaster> FunctionMaster { get; set; }
    }
}
