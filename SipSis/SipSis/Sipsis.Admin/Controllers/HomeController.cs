using Sipsis.Admin.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sipsis.Admin.Controllers
{
    [Auth]
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}