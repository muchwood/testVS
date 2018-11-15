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
    public class MapsController : Controller
    {
        private testEntities db = new testEntities();

        // GET: Maps
        public ActionResult Index()
        {
            return View(db.Map.ToList());

        }


        #region [Map]    
        [HttpPost]
        public JsonResult GetMap()
        {
            var data1 = Map();
            return Json(data1, JsonRequestBehavior.AllowGet);
        }
        public IEnumerable<Map> Map()
        {

            return (from p in db.Map
                    select new
                    {
                        
                        Latitude = p.Latitude,
                        Longitude = p.Longitude,                       
                        Description = p.Description,
                        Id = p.Id
                    }).ToList()
                .Select(res => new Map
                {
                    
                    Latitude = res.Latitude,
                    Longitude = res.Longitude,                    
                    Description = res.Description,
                    Id = res.Id


                });

        }
        #endregion
    }
}