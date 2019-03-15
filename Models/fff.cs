using core_bili.Myserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_bili.Models
{
    public class fff
    {
        private readonly IMyserver<student> ls;

        public fff(IMyserver<student> ls) {
            this.ls = ls;
        }
    }
}
