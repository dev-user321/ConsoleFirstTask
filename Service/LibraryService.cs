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
    public class LibraryService : IService<Library>
    {
        private LibraryRepository _repository;  

        public LibraryService()
        {
            _repository = new LibraryRepository();
        }
        public Library Add(Library t)
        {
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
    }
}
