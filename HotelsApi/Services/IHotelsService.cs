using System;
using System.Collections.Generic;

/*
an interface for my service which will be used to configure the service
as Dependency Injection in the form of Singleton class at the application level.
*/
namespace HotelsAPI.Services
{
    public interface IHotelsService
    {
        public List<Hotel> GetHotels(string sortBy,FilteringParams filteringParams);

        public Hotel GetHotel(string id);

        public Booking GetBooking(string id);

        public Booking UpdateBooking(string id, Booking bookItem);

        public string DeleteBooking(string id);

        public Booking AddBooking(Booking bookItem);
    }
}
