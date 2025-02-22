using System;
using Controller;
using Domain.Models;
using Service;
using Service.Helper;

namespace ConsoleAppFirstPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryController libraryController = new LibraryController();
            BookController bookController = new BookController();   
            GetMenu();
            while (true)
            {
                Console.Write("Seçiminizi edin: ");

                if (!int.TryParse(Console.ReadLine(), out int secim))
                {
                    Console.WriteLine("Yanlış seçim etdiniz!");
                    continue;
                }
                switch(secim)
                {
                    case (int)MenuTypes.CreateLibrary:
                        libraryController.Create();
                        break;
                    case (int)MenuTypes.UpdateLibrary:
                        libraryController.Update();
                        break;
                    case (int)MenuTypes.DeleteLibrary:
                        libraryController.Delete();
                        break;
                    case (int)MenuTypes.GetAllLibrary: 
                        libraryController.GetAll();
                        break;
                    case (int)MenuTypes.GetLibraryById:
                        libraryController.GetById();
                        break;
                    case (int)MenuTypes.SearchForLibrary: 
                        libraryController.Search();
                        break;
                    case (int)MenuTypes.CreateBook:
                        bookController.Create();
                        break;
                    case (int)MenuTypes.UpdateBook:
                        bookController.Update();
                        break;
                    case (int)MenuTypes.DeleteBook:
                        bookController.Delete();
                        break;
                    case (int)MenuTypes.GetAllBooks:
                        bookController.GetAll();
                        break;
                    case (int)MenuTypes.GetBookById:
                        bookController.GetBookById();
                        break;
                    case (int)MenuTypes.SearchForBook:
                        bookController.Search();
                        break;
                }
            }
        }
        static void GetMenu()
        {
            Console.WriteLine("1)Create Library , 2)Update Library , 3)Delete Library , " +
                "4)Get All Library , 5) Get Library By Id , 6)Search for Library\n");
            Console.WriteLine("7)Create Book , 8)Update Book , 9)Delete Library , " +
                "10)Get All Library , 11) Get Library By Id , 12)Search for Library\n");
        }
    }
}
