using Microsoft.AspNetCore.Mvc;
using System;

namespace MeetingApllicationProject.Controllers
{
    public class HomeController : Controller
    {
        // localhost/home URL'si ile karsimiza gelecek.
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //string selamlama = saat > 12 ? "İyi Günler" : "Günaydin";
            // string userName = "Mucahit";
            // ViewBag.Selamlama = selamlama;
            // ViewBag.UserName = userName;

            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydin";
            ViewBag.UserName = "Mucahit";
            return View();
        }
    }
}