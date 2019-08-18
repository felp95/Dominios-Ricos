using System;

namespace RoomBooking.Domain.Interfaces.Services
{
    public interface IBookService : IDisposable
    {
        void PlaceBook(Guid room, DateTime startDate, DateTime endDate);
    }
}
