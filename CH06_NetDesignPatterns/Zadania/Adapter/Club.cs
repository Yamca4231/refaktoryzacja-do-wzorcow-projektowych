using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Club
    {
        public void Party(Adult person)
        {
            if (person.IsAdult())
            {
                Console.WriteLine($"{person.Name} przeszedł walidację i może wejść do klubu!");
            }
            else
            {
                Console.WriteLine($"{person.Name} nie przeszedł walidacji i nie może wejść do klubu.");
            }
        }
    }
}