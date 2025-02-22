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
    public class LibraryRepository : IRepository<Library>
    {
        private static int count = 0;
        public void Add(Library t)
        {
            if(t == null)
            {
                Console.WriteLine("Library is not null !");
            }
            else
            {
                t.Id = count++;
                DataList<Library>._datas.Add(t);
            }
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                DataList<Library>._datas.Remove(item);
            }
        }

        public List<Library> GetAll()
        {
            return DataList<Library>._datas;
        }

        public Library GetById(int id)
        {
            return DataList<Library>._datas.FirstOrDefault(l => l.Id == id);
        }

      

        public void Update(int id, Library updatedLibrary)
        {
            var item = GetById(id);
            if (item != null)
            {
                int index = DataList<Library>._datas.IndexOf(item);
                DataList<Library>._datas[index] = updatedLibrary;
            }
        }
    }

}
