using Microsoft.AspNetCore.Mvc;

namespace MeetingApllicationProject.Controllers
{
    public class HomeController : Controller
    {
        //localhost/home url'si ile karsimiza gelecek.
        public IActionResult Index()
        {
            return View();
        }
    }
}