using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Dnata.TravelRepublic.Models;
using Newtonsoft.Json;

namespace Dnata.TravelRepublic.Services
{
    public class HotelService : IHotelService
    {
        public List<Hotel> GetHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/hotels.json")))
            {
                hotels = JsonConvert.DeserializeObject<List<Treatment>>(sr.ReadToEnd());
            }
        }
    }
}