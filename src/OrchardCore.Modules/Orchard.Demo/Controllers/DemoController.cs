using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Display;
using Orchard.DeferredTasks;
using Orchard.Demo.Models;
using Orchard.Demo.Services;
using Orchard.DisplayManagement;
using Orchard.Environment.Cache;
using Orchard.Events;
using YesSql.Core.Services;

namespace Orchard.Demo.Controllers
{
    public class DemoController : Controller
    {
        [Route("Demo")]
        [Route("Demo/Index")]
        public IActionResult Index()
        {
            return Content("Index content");
        }
        [Route("Demo/About")]
        public IActionResult About()
        {
            return Content("About content");
        }
        [Route("Demo/Contact")]
        public IActionResult Contact()
        {
            return Content("Contact content");
        }
    }
}