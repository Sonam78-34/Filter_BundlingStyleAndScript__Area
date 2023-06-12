using Microsoft.AspNetCore.Mvc.Filters;

namespace BundlingStyleAndScriptMVCASp.Filter
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action Executed before the resources executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action start executing after the resources start executing");
        }
    }
}
