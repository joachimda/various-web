using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CryptoController : Controller
    {
        // 
        // GET: /Crypto/

        public string Index()
        {
            return HtmlEncoder.Default.Encode("DEFAULT..");
        }

        // 
        // GET: /Crypto/Welcome/ 

        public string Welcome()
        {
            return "asd";
        }
    }
}