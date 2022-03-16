using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication3
{
    public class TestActionFilterAttribute : ActionFilterAttribute
    {
        private readonly ILogger<TestActionFilterAttribute> _logger;

        public TestActionFilterAttribute(ILogger<TestActionFilterAttribute> logger)//,string action
        {
            _logger = logger;
            //this.ActionName = action;
        }

        public string ActionName { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("do something.....");
            base.OnActionExecuting(context);
        }
    }
}