using Filters.CustomFilters;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        [ServiceFilter(typeof(ApiLoggingFilter))]
        public ActionResult test()
        {
            return Ok("Request feita em um endpoint com custom filter");
        }
    }
}
