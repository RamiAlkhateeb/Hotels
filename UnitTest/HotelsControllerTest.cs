using System;
using System.Linq;
using System.Collections.Generic;
using HotelsAPI.Controllers;
using HotelsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using HotelsAPI;


using Xunit;

namespace UnitTest
{
    public class HotelsControllerTest
    {

        HotelsController _controller;
        IHotelsService _service;

        public HotelsControllerTest()
        {
            _service = new HotelsService();
            _controller = new HotelsController(_service);

        }
        [Fact]
        public void GetAllTest()
        {
            //Arrange
            FilteringParams filterParameters = new FilteringParams();
            //Act
            var result = _controller.GetHotels("" ,filterParameters );
            //Assert
            Assert.IsType<ActionResult<List<Hotel>>>(result);
            var list = result as ActionResult<List<Hotel>>;
            
            Assert.IsType<List<Hotel>>(list.Value);

            var listHotels = list.Value as List<Hotel>;

            Assert.Equal(2, listHotels.Count);
        }

        [Theory]
        [InlineData("1", "3")]
        public void GetBookByIdTest(string id1,string id2)
        {
            //Arrange
            var validId = id1;
            var invalidId = id2;

            //Act
            var notFoundResult = _controller.GetHotel(invalidId);
            var okResult = _controller.GetHotel(validId);

            //Assert
            Assert.IsType<NotFoundResult>(notFoundResult.Result);
            Assert.IsType<ActionResult<Hotel>>(okResult);


            //Now we need to check the value of the result for the ok object result.
            var item = okResult as ActionResult<Hotel>;

            //We Expect to return a single book
            Assert.IsType<Hotel>(item.Value);

            //Now, let us check the value itself.
            var HotelItem = item.Value as Hotel;
            Assert.Equal(validId, HotelItem.ID);
            Assert.Equal("Sahid Montana", HotelItem.Name);
        }

        [Fact]
        public void AddBookingTest()
        {
           //OK RESULT TEST START
           
            //Arrange
            Booking newBooking = new Booking()
            {
                ID = "1",
                FullName = "Rami Alkhateeb",
                Phone = "85852552",
                Email = "rami13alkhateeb@gmail.com",
                StartDate = new DateTime(2022 , 1 , 13),
                EndDate = new DateTime(2022 , 1 , 15),
                AdultCount = 2,
                HotelId = "2"
            };

            //Act
            var createdResponse = _controller.AddBooking(newBooking);

            //Assert
            Assert.IsType<ActionResult<Booking>>(createdResponse);

            //value of the result
            var item = createdResponse as ActionResult<Booking>;
            Assert.IsType<Booking>(item.Value);

            //check value of this booking
            var bookItem = item.Value as Booking;
            Assert.Equal(newBooking.HotelId, bookItem.HotelId);
            Assert.Equal(newBooking.Email, bookItem.Email);
           
           //OK RESULT TEST END
           
           //BADREQUEST AND MODELSTATE ERROR TEST START

            //Arrange
            var incompleteBooking = new Booking()
            {
                ID = "1",
                FullName = "Rami Alkhateeb",
                Phone = "85852552",
                Email = "rami13alkhateeb@gmail.com",
            };

            //Act
            //_controller.ModelState.AddModelError("Title", "Title is a requried filed");
            var badResponse = _controller.AddBooking(incompleteBooking);

            //Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
           
           
           
            //BADREQUEST AND MODELSTATE ERROR TEST END
        }


    }
}
