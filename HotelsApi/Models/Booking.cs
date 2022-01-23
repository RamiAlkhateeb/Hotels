using System;
using System.Collections.Generic;

namespace HotelsAPI
{
    public class Booking
    {
        public String ID { get; set; }
        public String FullName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }

        public string HotelId {get;set;}
        public Hotel Hotel {get;set;}



    }
}
