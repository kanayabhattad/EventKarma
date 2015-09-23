//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class LocaleMaster
    {
       
        public  int Id { get; set; }
        public  string LocaleDescription { get; set; }
        public  string Locale { get; set; }

        public  ICollection<UserPreferences> UserPreferences { get; set; }
    }
}
