using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebPageTest.Models;

namespace WebPageTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GeoExample()
        {
            JSONToViewModel model = new JSONToViewModel();
            GeoHelper geoHelper = new GeoHelper();
            var result = await geoHelper.GetGeoInfo();
            model = JsonConvert.DeserializeObject<JSONToViewModel>(result);
            //TempData["GeoCode"] = result;
            return View(model);
        }

        //cuando llamamos la pagina pero con un parametro (ip) [c]
        [HttpPost]
        public async Task<ActionResult> GeoExample(string ip)
        {
            JSONToViewModel model = new JSONToViewModel();
            GeoHelper geoHelper = new GeoHelper();
            var result = await geoHelper.GetGeoInfo(ip);
            model = JsonConvert.DeserializeObject<JSONToViewModel>(result);
            //TempData["GeoCode"] = result;
            //ViewBag.mensaje = "IP obtenida";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}