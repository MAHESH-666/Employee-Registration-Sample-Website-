using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleData.Models
{
    public class TravelInfoViewModel
    {
            public IEnumerable<User> Users { get; set; }
            public IEnumerable<UserVehicle> UserVehicles { get; set; }
            public IEnumerable<TravelInfo> TravelInfos { get; set; }  

    }
}