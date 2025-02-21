using Domain.Models;
using Repository.Data;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository : IRepository<Book>
    {
        public void Add(Book t)
        {
            DataList<Book>._datas.Add(t);
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                DataList<Book>._datas.Remove(item);
            }
        }

        public List<Book> GetAll()
        {
            return DataList<Book>._datas;
        }

        public Book GetById(int id)
        {
            return DataList<Book>._datas.FirstOrDefault(l => l.Id == id);
        }

        public void Update(int id, Book updatedBook)
        {
            var item = GetById(id);
            if (item != null)
            {
                int index = DataList<Book>._datas.IndexOf(item);
                DataList<Book>._datas[index] = updatedBook;
            }
        }
    }
}
