using Microsoft.AspNetCore.Mvc.Filters;

namespace BundlingStyleAndScriptMVCASp.Filter
{
    public class ResourcesFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("Resoures executed after action end");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("Resources start executing ");
        }
    }
}
