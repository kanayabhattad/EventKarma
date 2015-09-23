//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    using System.Collections.Generic;

    public class TimezoneMaster
    {
        public  int Id { get; set; }
        public  string TimezoneString { get; set; }
        public  int TimestampOffset { get; set; }
        public  string IsDaylightSavingUsed { get; set; }
        public  int DaylightSavingOffset { get; set; }

        public  ICollection<UserPreferences> UserPreferenceses { get; set; }
    }
}
