using System.Diagnostics;
using LinkHub.Filters;
using LinkHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinkHub.Controllers
{
    [PaginaParaUsuarioLogado]
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
