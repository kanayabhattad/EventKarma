//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class LocaleMaster
    {
       
        public virtual int Id { get; set; }
        public virtual string LocaleDescription { get; set; }
        public virtual string Locale { get; set; }

        public virtual ICollection<UserPreferences> UserPreferences { get; set; }
    }
}
