using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Book : BaseModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
