using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Segment
    {
        //ID
        public int Id { get; set; }

        public int TripId { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }



        public DateTimeOffset StartDateTime { get; set; }

        public DateTimeOffset EndDateTime { get; set; }



        //Write a test

        public void Test()
        {
            
        }

    }
}
