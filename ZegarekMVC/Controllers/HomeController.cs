using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using ZegarekMVC.Models;
using KatGodzinaMinuta;

namespace ZegarekMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataForm dt = new DataForm();
            dt.Godzina = DateTime.Now;
            ViewData.Model = dt;
            return View();
        }
        
        
        [HttpPost]
        public ActionResult PobierzDane(DataForm data)
        {
           
             if (ModelState.IsValid)
             {
                GodzinaMinuta gm = new GodzinaMinuta(data.Godzina.Hour, data.Godzina.Minute);

                data.KatStopnie = gm.KatStopnie;
                data.KatRadiany = gm.KatRadiany;
                return View("Index", data);
             }
           
            else
            {
                return View();
            }
        }

  
    }
}