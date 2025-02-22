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
    public class LibraryService : ILibraryService
    {
        private IRepository<Library> _repository;  

        public LibraryService()
        {
            _repository = new LibraryRepository();
        }
        public Library Add(Library t)
        {
            if (t == null) return null;

            _repository.Add(t);
            return t;
        }

        public Library Delete(int id)
        {
            var result = _repository.GetById(id);
            _repository.Delete(id);
            return result;
        }

        public List<Library> GetAll()
        {
            return _repository.GetAll();    
        }

        public Library GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Library Update(int id, Library t)
        {
            _repository.Update(id, t);
            return t;
        }

        public List<Library> Search(string search)
        {
            List<Library> libraries = new List<Library>();
            var result = GetAll();
            foreach (var item in result) {
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
