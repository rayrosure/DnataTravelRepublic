using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dnata.TravelRepublic.Models;

namespace Dnata.TravelRepublic.Services
{
    public interface IHotelService
    {
        List<Hotel> GetHotels();
    }
}