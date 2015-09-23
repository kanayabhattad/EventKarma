using EventKarma.Data.Model;
using FluentNHibernate.Mapping;

namespace EventKarma.Data.MySql.Mapping
{
    public class TimezoneMasterMap : ClassMap<TimezoneMaster>
    {
        public TimezoneMasterMap()
        {
            Table("timezone_master");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.TimezoneString).Column("timezone_string").Not.Nullable();
            Map(x => x.TimestampOffset).Column("timestamp_offset").Not.Nullable();
            Map(x => x.IsDaylightSavingUsed).Column("is_daylight_saving_used").Not.Nullable();
            Map(x => x.DaylightSavingOffset).Column("daylight_saving_offset").Not.Nullable();
        }
    }
}
