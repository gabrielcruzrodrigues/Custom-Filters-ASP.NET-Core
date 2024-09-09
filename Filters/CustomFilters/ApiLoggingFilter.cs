using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.CustomFilters
{
    public class ApiLoggingFilter : IActionFilter
    {
        private readonly ILogger<ApiLoggingFilter> _logger;
        public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("aplicando ação após a execução!");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("aplicando ação durante a execução!");
        }
    }
}
