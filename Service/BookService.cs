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
    public class BookService : IService<Book>
    {
        private BookRepository _repository;

        public BookService()
        {
            _repository = new BookRepository();
        }

        public Book Add(Book t)
        {
            _repository.Add(t);
            return t;
        }
        public Book Delete(int id)
        {
            var result = _repository.GetById(id);
            _repository.Delete(id);
            return result;
        }

        public List<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Book Update(int id , Book book)
        {
            _repository.Update(id, book);
            return book;
        }
    }
}
