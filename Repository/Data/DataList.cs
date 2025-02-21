using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public static class DataList<T>
    {
        public static List<T> _datas;
        static DataList()
        {
            _datas = new List<T>();
        }
    }
}
