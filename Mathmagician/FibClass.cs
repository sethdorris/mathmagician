using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibNumbers : NaturalNumbers
    {
        protected int next = 0;
        public FibNumbers()
        {
            first = 1;
            increment = 1;
        }
        public override int GetNext(int x)
        {
            next = (x - 1) + (x - 2);
            return next;
        }

        public override int[] GetSequence()
        {
            return this.GetSequence(10);
        }

        public override int[] GetSequence(int x)
        {
            List<int> firstTen = new List<int> { };
            int a = 0;
            int b = 1;
            for (int i = 1; i < x + 1; i++)
            {
                int item = a;
                a = b;
                b = item + b;
                firstTen.Add(a);
            }
            return firstTen.ToArray();
        }
    }
}
