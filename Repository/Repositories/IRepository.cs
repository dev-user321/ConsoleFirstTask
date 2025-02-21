using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        void Add(T t);
        void Update(int id,T t);
        void Delete(int id);    
        List<T> GetAll();
        T GetById(int id);
    }
}
