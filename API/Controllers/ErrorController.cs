using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   [ApiExplorerSettings(IgnoreApi =true)]
    [Route("errors/{code}")]
    public class ErrorController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}