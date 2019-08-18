using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;

namespace RoomBooking.Domain.Interfaces.Repositories
{
    public interface IBookRepository : IDisposable
    {
        List<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate);

    }
}
