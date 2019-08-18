using RoomBooking.Domain.Interfaces.Services;
using System;

namespace RoomBooking.Console.Services
{
    public class BookService : IBookService
    {

        public void PlaceBook(Guid room, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
