using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Teenager
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Teenager(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public bool IsTeenager()
        {
            return Age < 18;
        }
    }
}
