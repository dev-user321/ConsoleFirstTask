using System;
using Domain.Models;
using Service;

namespace ConsoleAppFirstPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();

            while (true)
            {
                Console.WriteLine("1) Add Library\n2) Update Library\n3) Delete Library\n4) GetById Library\n5) Get All Library\n");
                Console.Write("Seçiminizi edin: ");

                if (!int.TryParse(Console.ReadLine(), out int secim))
                {
                    Console.WriteLine("Yanlış seçim etdiniz!");
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        Console.Write("Kitabxana adını daxil edin: ");
                        string name = Console.ReadLine();

                        Console.Write("Kitabxanada olan oturacaqların sayı: ");
                        if (!int.TryParse(Console.ReadLine(), out int seatsCount))
                        {
                            Console.WriteLine("Yanlış dəyər daxil etdiniz!");
                            continue;
                        }

                        Library library = new Library()
                        {
                            Name = name,
                            SeatsCount = seatsCount
                        };

                        libraryService.Add(library);
                        Console.WriteLine("Kitabxana uğurla əlavə edildi!");
                        break;

                    case 5:
                        var result = libraryService.GetAll();
                        foreach (var item in result)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim etdiniz!");
                        break;
                }
            }
        }
    }
}
