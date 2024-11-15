using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adult
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Adult(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual bool IsAdult()
        {
            return Age >= 18;
        }
    }
}

