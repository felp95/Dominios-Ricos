using System;
using System.Collections.Generic;

namespace RoomBooking.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; private set; }
        public Room Room { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public EBookStatus Status { get; private set; }

        public Book(Room room,DateTime startTime, DateTime endTime)
        {
            Id = new Guid();
            Room = room;
            Status = EBookStatus.InProgress;
            StartTime = startTime;
            EndTime = endTime;
        }

        public void Confirm(List<DateTime> holidays, List<DateTime> booksForThisPeriod)
        {
            if (Status != EBookStatus.InProgress)
            {
                throw new Exception("Error");
            }

            Status = EBookStatus.Reserved;
        }

        public void MarkAsInUse()
        {
            Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            if ((StartTime - DateTime.Now).Hours < 2)
            {
                throw new Exception("Error");
            }

            Status = EBookStatus.Canceled;
        }

        public void MarkAsCompleted()
        {
            Status = EBookStatus.Completed;
        }

    }
}
