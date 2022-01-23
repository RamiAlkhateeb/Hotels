using System;
using System.Collections.Generic;
using System.IO; // for File operation
using System.Linq;
using Newtonsoft.Json;

namespace HotelsAPI.Services
{
    public class HotelsService : IHotelsService
    {
        private List<Hotel> _hotelItems;

        private List<Booking> _bookingItems;

        Helper helper;

        public HotelsService()
        {
            _hotelItems = new List<Hotel>();
            _bookingItems = new List<Booking>();
            helper = new Helper();
        }

        public List<Hotel>
        GetHotels(string sortBy, FilteringParams filteringParams)
        {
            if (_hotelItems.Count == 0) _hotelItems = helper.SeedData();

            var minPrice = filteringParams.MinPrice;
            var maxPrice = filteringParams.MaxPrice;
            var searchString = filteringParams.SearchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                _hotelItems =
                    _hotelItems
                        .Where(h =>
                            h.Name.ToLower().Contains(searchString) ||
                            h.Location.ToLower().Contains(searchString))
                        .ToList();
            }

            if (minPrice > 0)
            {
                _hotelItems =
                    _hotelItems.Where(h => h.Price >= minPrice).ToList();
                if (maxPrice > 0)
                    _hotelItems =
                        _hotelItems
                            .Where(h =>
                                h.Price >= minPrice && h.Price <= maxPrice)
                            .ToList();
            }

            _hotelItems = helper.SortHotels(sortBy, _hotelItems);

            return _hotelItems;
        }

        public Hotel GetHotel(string id)
        {
            if (_hotelItems.Count == 0) _hotelItems = helper.SeedData();

            return _hotelItems.Find(h => h.ID == id);
        }

        public Booking GetBooking(string id)
        {
            return _bookingItems.Find(h => h.ID == id);
        }

        public Booking UpdateBooking(string id, Booking BookingItem)
        {
            var OldbookingItem = _bookingItems.Find(h => h.ID == id);
            _bookingItems.Remove(OldbookingItem);
            _bookingItems.Add(BookingItem);
            return BookingItem;
        }

        public string DeleteBooking(string id)
        {
            var bookingItem = _bookingItems.Find(h => h.ID == id);
            if (bookingItem != null)
                _bookingItems.Remove(bookingItem);
            else
                id = "Not Found";
            return id;
        }

        public Booking AddBooking(Booking bookingItem)
        {
            if (_hotelItems.Count == 0) _hotelItems = helper.SeedData();
            var bookings = _bookingItems.Where(b => b.HotelId == bookingItem.HotelId).ToList();
            var hotel = _hotelItems.Find(h => h.ID == bookingItem.HotelId);

            if (bookings.Count > 0)
            {
                var bookingCount =
                    hotel
                        .Bookings
                        .Where(b =>
                            b.StartDate >= bookingItem.StartDate ||
                            b.EndDate <= bookingItem.EndDate)
                        .ToList()
                        .Count();
                if (bookingCount >= hotel.RoomsCount) // not available
                    bookingItem = null;
                else
                {
                    hotel.Bookings = new List<Booking>();
                    bookings.Add(bookingItem);
                    _bookingItems.Add(bookingItem);
                    hotel.Bookings= bookings;
                }
                
            }
            else
            {
                hotel.Bookings = new List<Booking>();
                bookings.Add(bookingItem);
                _bookingItems.Add(bookingItem);
                hotel.Bookings= bookings;
            }

            return bookingItem;
        }
    }
}
