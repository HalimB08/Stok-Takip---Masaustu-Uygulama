using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Authorization { get; set; }
        public string Active { get; set; }
    }
}
