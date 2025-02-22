using Domain.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BookController
    {

        BookService bookService = new BookService();
        public void Create()
        {
            Console.WriteLine("Added the name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Added the author : ");
            string author = Console.ReadLine();
            Console.WriteLine("Added the id : ");
            string identity = Console.ReadLine();
            int id = int.Parse(identity);

            Book book = new Book()
            {
                Name = name,
                Author = author
            };

            bookService.Create(id, book);
            Console.WriteLine("Added Succesfully !");
        }

        public void Update()
        {
            Console.WriteLine("Added the name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Added the Author : ");
            string author = Console.ReadLine();
            Console.WriteLine("Added the Library Id : ");
            string libId = Console.ReadLine();
            int libraryId = int.Parse(libId);
            Console.WriteLine("Added the Book Id : ");
            string identity = Console.ReadLine();
            int id = int.Parse(identity);

            Book book = new Book()
            {
                Name = name,
                Author = author
            };

            bookService.Update(id,book,libraryId);
            Console.WriteLine("Update Succesfully !");
        }

        public void Delete()
        {
            Console.WriteLine("Added the Id : ");
            string identity = Console.ReadLine();
            int id = int.Parse(identity);
            bookService.Delete(id);
            Console.WriteLine("Book Delete Succesfully !");
        }

        public void GetAll()
        {
            var result = bookService.GetAllBooks();

            foreach (var book in result)
            {
                Console.WriteLine(book);
            }
        }

        public void GetBookById()
        {
            Console.WriteLine("Added the Id : ");
            string identity = Console.ReadLine();
            int id = int.Parse(identity);
            Console.WriteLine(bookService.GetById(id));    
        }

        public void Search()
        {
            Console.WriteLine("Added the search : ");
            string search = Console.ReadLine(); 

            foreach(var book in bookService.Search(search))
            {
                Console.WriteLine(book);
            }
        }
    }
}
