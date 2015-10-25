using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mathmagician
{
    public class NaturalNumbers //By default every class has a constructor that takes no arguments
    {
        //By default, first set to 0 if not explicitly defined
        protected int first;
        protected int increment;

        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }

        public int GetFirst()
        {
            return first;
        }

        public virtual int GetNext(int x)
        {
            return x + increment;
        }

        public virtual int[] GetSequence()
        {
            return GetSequence(10);
        }

        public virtual int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            return output;
        }

    }
}
