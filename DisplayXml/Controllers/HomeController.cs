namespace DisplayXml.Controllers
{
    using Services.Contracts;
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using DisplayXml.Models;

    public class HomeController : Controller
    {
        private readonly IXmlParserService _xmlParser;

        public HomeController(IXmlParserService xmlParser)
        {
            this._xmlParser = xmlParser;
        }

        public IActionResult Index()
        {
            var model = this._xmlParser.GetLastTenArticles();
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
