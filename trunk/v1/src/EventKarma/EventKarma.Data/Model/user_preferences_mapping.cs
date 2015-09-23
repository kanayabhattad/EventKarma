//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Data.Model
{
    public partial class UserPreferencesMapping
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int PreferenceId { get; set; }
        public virtual User User { get; set; }
    }
}
