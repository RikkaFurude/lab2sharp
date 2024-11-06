using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sharp
{
    class Child : Parent
    {
        public int a2, b2, c2;
        public Child(int a2, int b2, int c2)   
        {
            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
        }
        public double Russian_roulette()
        {
            double p, S;
            p = (a2 + b2 + c2) / 2;
            if (a2 >= 0 && b2 >= 0 && c2 >= 0) { 
            S = Math.Sqrt(p * (p - a2) * (p - b2) * (p - c2));
            }
                else
                {
                S = 0;
                }
              return S;
       }     
        public void GOOOOL()    
        {
            if (a2 == b2 || a2 == c2 || b2 == c2) Console.WriteLine("ГООООООЛ");
            else Console.WriteLine("НЕ ГООООООЛ");
        }
        public override string ToString()
        {
            base.ToString();
            string s = $"{a2}, {b2}, {c2}";
            return s;
        }
    }    
    
}
