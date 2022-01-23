using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelsController : ControllerBase
    {
        //private ILogger _logger;

        private IHotelsService _service;

        public HotelsController(IHotelsService service)
        {
            _service = service;
        }

        [HttpGet("/api/hotels")]
        public ActionResult<List<Hotel>> GetHotels(string sortBy, [FromQuery] FilteringParams filterParameters)
        {
            return _service.GetHotels(sortBy,filterParameters);;
        }

        [HttpGet("/api/hotels/{id}")]
        public ActionResult<Hotel> GetHotel(string id)
        {
            var hotel = _service.GetHotel(id);
            if(hotel != null)
                return hotel;
            else
                return NotFound();
        }

        [HttpPost("/api/bookings")]
        public ActionResult<Booking> AddBooking(Booking booking)
        {
            if (string.IsNullOrEmpty(booking.HotelId))
                return BadRequest("request is incorrect");
            else
            {
                if(_service.AddBooking(booking) != null)
                    return booking;
                else
                    return NotFound();
            }
            
        }

        [HttpGet("/api/bookings/{id}")]
        public ActionResult<Booking> GetBooking(string id)
        {
            if(_service.GetBooking(id) != null)
                return _service.GetBooking(id);
            else
                return NotFound();
        }

        [HttpPut("/api/bookings/{id}")]
        public ActionResult<Booking> UpdateBooking(string id, Booking booking)
        {
                
            if (string.IsNullOrEmpty(booking.HotelId))
                return BadRequest("request is incorrect");
            else{
                _service.UpdateBooking(id, booking);
                return booking;
            }
               
        }

        [HttpDelete("/api/bookings/{id}")]
        public ActionResult<string> DeleteBooking(string id)
        {            
            return _service.DeleteBooking (id);
        }
    }

    
}
