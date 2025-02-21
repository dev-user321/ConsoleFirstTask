using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IService<T> 
    {
        T Add(T t);
        T Update(int  id,T t);
        T Delete (int id);
        List<T> GetAll();
        T GetById(int id);  
    }
}
