using Domain.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LibraryController
    {
        LibraryService libraryService = new LibraryService();
        public void Create()
        {
            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the seatscount : ");
            string seatsCount = Console.ReadLine();
            int count = int.Parse(seatsCount);

            Library library = new Library()
            {
                Name = name,
                SeatsCount = count
            };

            libraryService.Add(library);
            Console.WriteLine("Library Added Succesfully!");
        }

        public void Update()
        {
            Console.WriteLine("Added the id : ");
            string identity = Console.ReadLine();
            int id = int.Parse(identity);
            Console.WriteLine("Added new name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Added new seatsCount : ");
            string seatsCount = Console.ReadLine(); 
            int count = int.Parse(seatsCount);
            Library library2 = new Library()
            {
                Name = name,
                SeatsCount = count
            };
            libraryService.Update(id, library2);
            Console.WriteLine("Update Succesfully !");
        }

        public void Delete()
        {
            Console.WriteLine("Added the id : ");
            string identity = Console.ReadLine();
            int id = int.Parse(identity);   
            libraryService.Delete(id);
            Console.WriteLine("Delete Successfully !");
        }

        public void GetAll()
        {
            foreach (var item in libraryService.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Added the id : ");
            string identity = Console.ReadLine();   
            int id = int.Parse(identity);
            Console.WriteLine(libraryService.GetById(id));
        }

        public void Search()
        {
            Console.WriteLine("Added the Search : ");
            string search = Console.ReadLine();
            foreach (var item in libraryService.Search(search))
            {
                Console.WriteLine(item);
            }
        }

    }
}
