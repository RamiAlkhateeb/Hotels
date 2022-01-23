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

        public HotelsController(
            //ILogger<HotelsController> logger,
            IHotelsService service
        )
        {
            //_logger = logger;
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
                _service.AddBooking(booking);
                return booking;
            }
            
        }

        [HttpGet("/api/bookings/{id}")]
        public ActionResult<Booking> GetBooking(string id)
        {
            return _service.GetBooking(id);
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

        [HttpDelete("/api/hotels/{id}")]
        public ActionResult<string> DeleteBooking(string id)
        {
            _service.DeleteBooking (id);

            //_logger.LogInformation("hotels", _hotels);
            return id;
        }
    }

    
}
