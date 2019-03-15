using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_bili.Myserver
{
    public class Mydata : IMyserver<student>
    {
        public IEnumerable<student> GetAll()
        {
            return new List<student> { new student { id = 1, name = "aa" }, new student { id = 2, name = "bb" }, new student { id = 3, name = "cc" } };
        }
    }
}
