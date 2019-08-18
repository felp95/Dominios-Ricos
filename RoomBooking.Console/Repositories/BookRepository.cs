using System;
using System.Collections.Generic;
using System.Text;
using RoomBooking.Domain.Entities;
using RoomBooking.Domain.Interfaces.Repositories;

namespace RoomBooking.Console.Repositories
{
    class BookRepository : IBookRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
