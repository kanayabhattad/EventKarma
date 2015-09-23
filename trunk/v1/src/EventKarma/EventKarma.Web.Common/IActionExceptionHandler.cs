using System.Web.Http.Filters;

namespace EventKarma.Web.Common
{
    public interface IActionExceptionHandler
    {
        void HandleException(HttpActionExecutedContext filterContext);
    }
}
