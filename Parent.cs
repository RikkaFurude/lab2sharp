using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sharp
{
    public class Parent
    {

        private protected int a;
        private protected int b;
        private protected int c;

        public Parent()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Parent(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }


        public Parent(Parent parents)
        {
            a = parents.a;
            b = parents.b;
            c = parents.c;
        }
        public void Max()
        {
            int max = Math.Max(a, b);
            max = Math.Max(c, max);
            Console.WriteLine(max);
        }

        public string Tostring(int z, int x, int q)
        {
            string s = $"{z}, {x}, {q}";
            return s;
        }
        public override string ToString()
        {
            base.ToString();
            string s = $"{a}, {b}, {c}";
            return s;
        }


    }
}
