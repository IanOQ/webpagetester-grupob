using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPageTest.Models
{
    public class JSONToViewModel
    {
       
        [JsonProperty("ip")]

        public string Ip { get; set; }
        

       [JsonProperty("type")]

       public string Type { get; set; }
       

        [JsonProperty("country_code")]

        public string CountryCode { get; set; }


        [JsonProperty("country_name")]

        public string CountryName { get; set; }


        [JsonProperty("region_code")]

        public string RegionCode { get; set; }


        [JsonProperty("region_name")]

        public string RegionName { get; set; }


        [JsonProperty("city")]

        public string City { get; set; }


        [JsonProperty("zip")]

        public string ZipCode { get; set; }


        [JsonProperty("latitude")]

        public decimal Latitude { get; set; }


        [JsonProperty("longitude")]

        public string Longitude { get; set; }

        /*
        [JsonProperty("location.languages")]

        public Object Location { get; set; }
        */

        [JsonProperty("security")]

        public Object Security { get; set; }

    }
}