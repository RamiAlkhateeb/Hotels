using System;
using System.Collections.Generic;

namespace HotelsAPI
{
    public class FilteringParams
    {
        public double MaxPrice { get; set; } 

        public double MinPrice { get; set; } 

        public string SearchString {get; set;} 
    }
}
