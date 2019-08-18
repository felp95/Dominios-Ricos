using RoomBooking.Domain.Validation.SpaUserControl.Common.Validation;
using System;

namespace RoomBooking.Domain.Entities
{
    public class Room
    {
        public Guid Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Title { get; private set; }

        public Room(DateTime startDate, DateTime endDate, string title)
        {
            AssertionConcern.AssertArgumentNotNull(startDate, "Horário de início inválido");
            AssertionConcern.AssertArgumentNotNull(endDate, "Horário de término inválido");
            AssertionConcern.AssertArgumentLength(title,3,40, "Nome da sala deve conter entre 3 e 40 caracteres");

            Id = new Guid();
            StartDate = startDate;
            EndDate = endDate;
            Title = title;
        }

    }
}
