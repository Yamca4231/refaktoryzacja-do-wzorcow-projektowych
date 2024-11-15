using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class FakeAdult : Adult
    {
        private Teenager _teenager;

        public FakeAdult(string name,int age) : base(name, age)
        {
        }

        public override bool IsAdult()
        {
            // Zawsze zwracamy true, aby oszukać walidację
            return true;
        }
    }
}
