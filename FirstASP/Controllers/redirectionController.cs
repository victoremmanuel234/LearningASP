using Microsoft.AspNetCore.Mvc;
using FirstASP.Models;

namespace FirstASP.Controllers
{
    public class redirectionController : Controller
    {
        //
        [Route("test/modelvalidation")]
        [Route("learn/method3")] 
        [Route("store/{bookId:int}/{bookName:alpha}/{bookAuthor:alpha}")]
        public IActionResult Index(ModelExample model)
        {
            if(!ModelState.IsValid)
            {
                string errors = string.Join("\n", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return BadRequest(errors);
            }
            return Content($"this is the method3 from redirected controller: {model}");
        }

    }
}
