using System.Web.Mvc;

namespace CreationsByKittery.Features.Home
{
    public partial class HomeController 
    {
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}