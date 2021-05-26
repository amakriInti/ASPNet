using System.Web;
using System.Web.Mvc;

namespace DemoTodo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MesFiltres());
        }
    }
    public class MesFiltres : HandleErrorAttribute, IActionFilter, IResultFilter, IAuthorizationFilter
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
        // 1
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }
    }
}
