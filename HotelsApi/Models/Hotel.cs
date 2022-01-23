using System;
using System.Collections.Generic;

namespace HotelsAPI
{
    public class Hotel
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
        public String Phone { get; set; }
        public int Stars { get; set; }        
        public float ReviewScore {get;set;}
        public int RoomsCount {get; set;}
        public double Price {get;set;}
        public List<String> Facilities { get; set; }
        public List<String> ImgaesUrls { get; set; }
        public List<String> Reviews { get; set; }

        public List<Booking> Bookings { get; set; }


    }
}
