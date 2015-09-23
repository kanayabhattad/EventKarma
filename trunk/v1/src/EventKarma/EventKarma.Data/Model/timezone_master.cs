//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    using System.Collections.Generic;

    public class TimezoneMaster
    {
        public virtual int Id { get; set; }
        public virtual string TimezoneString { get; set; }
        public virtual int TimestampOffset { get; set; }
        public virtual string IsDaylightSavingUsed { get; set; }
        public virtual int DaylightSavingOffset { get; set; }

        public virtual ICollection<UserPreferences> UserPreferenceses { get; set; }
    }
}
