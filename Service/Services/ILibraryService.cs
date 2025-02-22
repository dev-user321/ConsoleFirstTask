using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface ILibraryService
    {
        Library Add(Library library);

        Library Update(int id, Library library);

        Library Delete(int id);

        List<Library> GetAll();

        Library GetById(int id);
        List<Library> Search(string search);

    }
}
