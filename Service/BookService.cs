using Domain.Models;
using Repository;
using Repository.Repositories;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookService : IBookService
    {
        private IRepository<Book> _repository;
        private IRepository<Library> _libraryRepository;
        static int count = 0;
        public BookService()
        {
            _repository = new BookRepository();
            _libraryRepository = new LibraryRepository();
        }
        public Book Create(int id, Book book)
        {
            var library = _libraryRepository.GetById(id);
            book.Id = count++;
            book.Library = library;

            _repository.Add(book);
            return book;
            
        }

        public Book Delete(int id)
        {
            var result = _repository.GetById(id);
            _repository.Delete(id);
            return result;
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetAll();
        }

        public Book GetById(int id)
        {
            return _repository.GetById(id);
        }
        public Book Update(int id,Book book,int libraryId)
        {
            var library = _libraryRepository.GetById(libraryId);
            book.Library = library;
            _repository.Update(id, book);   
            return book;
        }
        public List<Book> Search(string search)
        {
            List<Book> libraries = new List<Book>();
            var result = GetAllBooks();
            foreach (var item in result)
            {
                if (item.Name.Trim().ToLower().StartsWith(search.Trim().ToLower()))
                {
                    libraries.Add(item);
                }
                else
                {
                    continue;
                }
            }
            return libraries;
        }

        
    }
}
