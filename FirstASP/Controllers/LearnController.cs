using Microsoft.AspNetCore.Mvc;



namespace FirstASP.Controllers
{
   public class LearnController : Controller 
    {
        [Route("learn/method1")]
        [Route("/")]
        public IActionResult Method1()
        {
            return Content("this is the method1 and default method from learn controller");
        }

        [Route("learn/method2")]
        public IActionResult Method2()
        {
            return RedirectToActionPermanent("Index", "redirection");
        }
    }
}