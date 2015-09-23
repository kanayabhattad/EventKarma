using System.Web.Http;

namespace EventKarma.Web.Common.Security
{
    public class AdministratorAuthorized : AuthorizeAttribute
    {
        public AdministratorAuthorized()
        {
            Roles = "Administrators";
        }
    }
}
