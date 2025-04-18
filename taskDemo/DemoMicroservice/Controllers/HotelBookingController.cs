using Microsoft.AspNetCore.Mvc;
using DemoMicroservice.Data;
using DemoMicroservice.Models;

namespace DemoMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelBookingController : ControllerBase
    {
        private readonly ApiContext _context;

        public HotelBookingController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<HotelBooking> Create(HotelBooking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return Ok(booking);
        }

        [HttpPut("update/{id}")]
        public ActionResult<HotelBooking> Update(int id, HotelBooking updatedBooking)
        {
            var bookingInDb = _context.Bookings.Find(id);
            if (bookingInDb == null)
            {
                return NotFound("Booking not found");
            }

            // Update only the available fields
            bookingInDb.RoomNumber = updatedBooking.RoomNumber;
            bookingInDb.ClientName = updatedBooking.ClientName;

            _context.SaveChanges();
            return Ok(bookingInDb);
        }


        //get
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var result = _context.Bookings.Find(id);

            if (result == null)
            {
                return new JsonResult(NotFound("Booking not found"));
            }

            return new JsonResult(Ok(result));
        }

        //Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking == null)
            {
                return new JsonResult(NotFound("Booking not found"));
            }

            _context.Bookings.Remove(booking);
            _context.SaveChanges();
            return new JsonResult(Ok("Booking deleted successfully"));
        }

        //Get all bookings
        [HttpGet("/GetAll")]
        public JsonResult GetAll()
        {
            var bookings = _context.Bookings.ToList();
            return new JsonResult(Ok(bookings));
        }
    }
}
