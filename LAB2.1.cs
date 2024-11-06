using System;
using System.Runtime.Intrinsics.X86;

namespace lab2sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int a1, b1, c1, a2, b2, c2;
            Console.WriteLine("Введите а1");
            s=Console.ReadLine();
            try
            {
                a1 = Convert.ToInt32(s);
            }
            catch
            {
                Console.WriteLine("a Не является типом int");
                throw;
            }
            Console.WriteLine("Введите b1");
            s =Console.ReadLine();
            try
            {
                b1 = Convert.ToInt32(s);
            }
            catch
            {
                Console.WriteLine("b Не является типом int");
                throw;
            }
            Console.WriteLine("Введите c1");
            s =Console.ReadLine();
            try
            {
                c1 = Convert.ToInt32(s);
            }
            catch
            {
                Console.WriteLine("c Не является типом int");
                throw;
            }
            Console.WriteLine("Введите a2");
            s =Console.ReadLine();
            try
            {
                a2 = Convert.ToInt32(s);
            }
            catch
            {
                Console.WriteLine("a Не является типом int");
                throw;
            }
            Console.WriteLine("Введите b2");
            s = Console.ReadLine();
            try
            {
                b2= Convert.ToInt32(s);
            }
            catch
            {
                Console.WriteLine("b Не является типом int");
                throw;
            }
            Console.WriteLine("Введите c2");
            s = Console.ReadLine();
            try
            {
                c2 = Convert.ToInt32(s);
            }
            catch
            {
                Console.WriteLine("c Не является типом int");
                throw;
            }
            Console.WriteLine();
            Parent One = new Parent(a1, b1, c1);
            Parent Two = new Parent(One);
            Child Third = new Child (a2,b2,c2);
            Console.Write("Максимальное из a1,b1,c1: ");
            One.Max();
            s=Two.ToString();
            Console.Write("a1,b1,c1 в виде строки: ");
            Console.WriteLine(s);
            s = Third.ToString();
            Console.Write("a2,b2,c2 в виде строки: ");
            Console.WriteLine(s);
            double q=Third.Russian_roulette();
            Console.Write("Площадь треугольника со сторонами a2b2c2: ");
            Console.WriteLine(q);
            Console.Write("Является ли треугольник равнобедренным: ");
            Third.GOOOOL();
        }
    }
}
