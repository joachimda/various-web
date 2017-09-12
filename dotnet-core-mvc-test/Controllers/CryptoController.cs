using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CryptoController : Controller
    {
        // 
        // GET: /Crypto/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Crypto/Welcome/ 

        public string Welcome()
        {
            return "asd";
        }
    }
}