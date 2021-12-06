using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebPageTest
{
    public class GeoHelper
    {
        private readonly HttpClient _httpClient;
        public GeoHelper()
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5)
            };
        }
        private async Task<string> GetIPAddress()
        {
            var ipAddress = await _httpClient.GetAsync($"http://ipinfo.io/ip");
            if (ipAddress.IsSuccessStatusCode)
            {
                var json = await ipAddress.Content.ReadAsStringAsync();
                return json.ToString(); //"181.194.161.53"; //Here receives the ip
            }
            return "";
        }
        public async Task<string> GetGeoInfo()
        {
            //I have already created this function under GeoInfoProvider class.
            var ipAddress = await GetIPAddress();
            // When geting ipaddress, call this function and pass ipaddress as given below
            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=8d63d20667987bb82dcb80df8cdcaa9b&format=1");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }

        //hace lo mismo que la clase de arriba, pero con una IP que le suministremos
        public async Task<string> GetGeoInfo(string ip)
        {
            //var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ip + "?access_key=8d63d20667987bb82dcb80df8cdcaa9b&format=1");
            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ip + "?access_key=b6fbd13f3f6611d5da55372b085514ee&format=1");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }
    }//end class

  }//end