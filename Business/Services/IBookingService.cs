using Business.Models;

namespace Business.Services
{
    public interface IBookingService
    {
        Task<BookingResult> CreateBookingAsync(BookingCreateRequest request);
    }
}