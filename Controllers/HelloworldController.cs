using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoMVC_ASPCORE.Controllers
{
    public class HelloworldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numtimes=1 )
        {
            // return HtmlEncoder.Default.Encode($"Hello { name}, Numtimes is: {numtimes} ");
            ViewData["Message"] = "Hello " + name;
            ViewData["Numtimes"] = numtimes;
            return View();
        }
    }
}
