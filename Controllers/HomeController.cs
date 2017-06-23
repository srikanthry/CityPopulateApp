using CityPopulateApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityPopulateApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public JsonResult UpdateCityDetails(string city, int population)
        {
            List<City> cityList = new List<City>();
            string path = Server.MapPath("~/App_Data/Cities.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                cityList = JsonConvert.DeserializeObject<List<City>>(json);
            }
            cityList.Find(item => item.city.Equals(city)).pop = population;
            string jsonData = JsonConvert.SerializeObject(cityList, Formatting.None);
            System.IO.File.WriteAllText(Server.MapPath("~/App_Data/Cities.json"), jsonData);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetJsonData()
        {
            List<City> cityList = new List<City>();
            string path = Server.MapPath("~/App_Data/Cities.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                cityList = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }
    }
}