//use for IC08
//Lydia's Code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets       //ERROR OR JUST QUALITY ISSUE, MAYBE BE MORE SPECIFIC WHAT THIS CODE DOES. FOR EXAMPLE: // "Create Random scanner object "r" and create FOR Loop". 
            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            //Display each set and the union
            Console.WriteLine ("A: " + A);  
            Console.WriteLine ("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //Display original sets (shoudl be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for(int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                // else
                //   return false; ------> Shouldn't these be removed? Becuase there are two FALSE statements within the loopS structure?
                // Is this not more of a logical error? Remove the else statement on lin 60 and also remove the return statement on line 61. 
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + "";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            for( int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;
        }
    }
}
