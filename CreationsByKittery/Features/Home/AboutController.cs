using System.Web.Mvc;

namespace CreationsByKittery.Features.Home
{
    public partial class HomeController
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}