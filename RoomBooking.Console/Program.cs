using System;
using System.Collections.Generic;
using RoomBooking.Console.Repositories;
using RoomBooking.Console.Services;
using RoomBooking.Domain.Entities;
using RoomBooking.Domain.Interfaces.Repositories;
using RoomBooking.Domain.Interfaces.Services;
using Unity;
using Unity.Lifetime;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();
            //container.RegisterType<IBookRepository, BookRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            //var bookRepository = container.Resolve<IBookRepository>();
            //var bookService = container.Resolve<IBookService>();

            var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");
            System.Console.WriteLine("Criando a Sala");

            var book = new Book(room, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2));
            System.Console.WriteLine("Iniciando a Reserva");

            book.Confirm(new List<DateTime>(), new List<DateTime>());
            System.Console.WriteLine("Status da reserva: {0}", book.Status);

            book.MarkAsInUse();
            System.Console.WriteLine("Status da reserva: {0}", book.Status);

            System.Console.ReadKey();
        }
    }
}
