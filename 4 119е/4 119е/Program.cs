using System;

namespace _4_119е
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Введите  EPS > 0(Заданная точность");
            bool ok;
            double e;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out e);
                if (!ok) Console.WriteLine("Это не число ");
                if (e <= 0) { Console.WriteLine("Е > 0"); ok = false; }
            } while (!ok);
            double s = 0;
            int i = 0;
            double f = 1;                      
            s = 1 / f;
            while (1 / f > e)
            {
                i = i + 1;
                f = Math.Pow(4, i) + Math.Pow(5, i + 2);
                s = s + 2 / f;
            }
               
            Console.WriteLine("Сумма ряда = " + s);
        }
    }
}
 

