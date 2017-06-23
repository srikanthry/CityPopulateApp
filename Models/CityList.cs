using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityPopulateApp.Models
{
    public class CityList
    {
        public List<City> Cities { get; set; }
    }

    public class City
    {
        public string city { get; set; }
        public int pop { get; set; }
        public string state { get; set; }
        public string _id { get; set; }
    }
}