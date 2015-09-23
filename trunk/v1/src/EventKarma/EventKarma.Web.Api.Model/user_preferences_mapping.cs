//------------------------------------------------------------------------------

//------------------------------------------------------------------------------

namespace EventKarma.Web.Api.Model
{
    public partial class UserPreferencesMapping
    {
        public  int Id { get; set; }
        public  int UserId { get; set; }
        public  int PreferenceId { get; set; }
        public  User User { get; set; }
    }
}
