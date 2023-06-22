
using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("error/{code}")]
    [ApiExplorerSettings(IgnoreApi =true)]
    public class ErrorController:BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new OkObjectResult(new ApiResponse(code));
        }
    }
}