﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Protfolio.Controllers
{
    public class DefaultController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonList()
        {
            return View();
        }
        public ActionResult DepartmanList()
        {
            return View();
        }
    }
}