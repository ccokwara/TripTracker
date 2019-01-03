using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Trip
    {
        //ID
        public int Id { get; set; }

        //Name of the trip guy
        public string Name { get; set; } 

        //StartDate
        public DateTime StartDate { get; set; }

        //EndDate
        public DateTime EndDate { get; set; }

        public static explicit operator List<object>(Trip v)
        {
            throw new NotImplementedException();
        }
    }
}
