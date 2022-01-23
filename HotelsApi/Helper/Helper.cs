using System;
using System.Collections.Generic;
using System.IO; // for File operation
using System.Linq;
using Newtonsoft.Json;

namespace HotelsAPI
{
    public class Helper 
    {
        private List<Hotel> _hotelItems;

        public List<Hotel> SeedData()
        {
            using (StreamReader r = new StreamReader("./Seed.json"))
            {
                string json = r.ReadToEnd();
                _hotelItems = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }
            return _hotelItems;
        }

        public List<Hotel> SortHotels(string sortBy,List<Hotel> _hotelItems)
        {
            switch (sortBy)
            {
                case "cheapest_first":
                    _hotelItems = _hotelItems.OrderBy(h => h.Price).ToList();
                    break;
                case "top_rates":
                    _hotelItems =
                        _hotelItems
                            .OrderByDescending(h => h.ReviewScore)
                            .ToList();
                    break;
                case "recommended":
                    _hotelItems =
                        _hotelItems.OrderByDescending(h => h.Stars).ToList();
                    break;
                case "popular":
                    _hotelItems =
                        _hotelItems
                            .OrderByDescending(h => h.Reviews.Count)
                            .ToList();
                    break;
                default:
                    _hotelItems =
                        _hotelItems
                            .OrderByDescending(h => h.Facilities.Count)
                            .ToList();
                    break;
            }
            return _hotelItems;

            
        }
    }
}
