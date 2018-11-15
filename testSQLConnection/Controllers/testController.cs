using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using testSQLConnection.Models;

namespace testSQLConnection.Controllers
{
    public class testController : Controller
    {
        private testEntities db = new testEntities();

        // GET: Maps    
        public ActionResult Index()
        {
            return View(db.Aves.ToList());
        }
    }
}