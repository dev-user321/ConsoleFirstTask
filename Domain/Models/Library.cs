using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Library : BaseModel
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , SeatsCount : {SeatsCount}";
        }

    }
}
