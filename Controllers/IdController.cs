using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class IdController : Controller
    {
        [Authorize, HttpPost(), Route("~/Id")]
        [HttpGet()]
        public async Task<ActionResult> Index(CancellationToken cancellationToken)
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");//Refresh
        }
    }
}