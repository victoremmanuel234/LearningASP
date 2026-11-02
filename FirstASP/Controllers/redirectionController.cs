using Microsoft.AspNetCore.Mvc;
using FirstASP.Models;

namespace FirstASP.Controllers
{
    public class redirectionController : Controller
    {
        //
        [Route("learn/method3")] 
        [Route("store/{bookId:int}/{bookName:alpha}/{bookAuthor:alpha}")]
        public IActionResult Index([FromRoute] ModelExample model)
        {
            return Content($"this is the method3 from redirected controller: {model}");
        }

    }
}
