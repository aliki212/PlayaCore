using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlayaCore.Controllers
{
    public class PlayaController : Controller
    {
        public ActionResult List()
        {
            return View();
        }
    }
}
