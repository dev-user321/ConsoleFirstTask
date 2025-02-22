using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IBookService
    {
        Book Create (int id,Book book);

        Book Update (int id,Book book,int libraryId);

        Book Delete(int id);

        List<Book> GetAllBooks();   
        Book GetById (int id);
        List<Book> Search(string search);
    }
}
