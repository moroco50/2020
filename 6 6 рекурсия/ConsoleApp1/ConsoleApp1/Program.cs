using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Function(int n, int[] mas)
        {
            if (n > 3)
            {
                Function(n - 1, mas);
            }

            mas[n] = mas[n - 1] + mas[n - 2] / 3 + 3 * mas[n - 3];
        }

        static void Main(string[] args)
        {
            int a1, a2, a3, n;
            bool ok;

            Console.WriteLine("Введите а1");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out a1);
                if (!ok) Console.WriteLine("Введите корректное значение");

            } while (!ok);

            Console.WriteLine("Введите а2");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out a2);
                if (!ok) Console.WriteLine("Введите корректное значение");

            } while (!ok);

            Console.WriteLine("Введите а3");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out a3);
                if (!ok) Console.WriteLine("Введите корректное значение");

            } while (!ok);

            Console.WriteLine("Введите N");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok || n < 4) Console.WriteLine("Введите корректное значение");
                if (n < 4) Console.WriteLine("N > 3");

            } while (!ok);

            int m;
            Console.WriteLine("Введите M");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out m);
                if (!ok) Console.WriteLine("Введите корректное значение");

            } while (!ok);

             int[] mas = new int[n];
             mas[0] = a1;
             mas[1] = a2;
             mas[2] = a3;

             Function(n - 1, mas);
             Console.WriteLine($"Последовательность: {String.Join(" ", mas)}");

            
            int k = 0;
            for (int i=0;i<mas.Length;i++)
            {
                if (mas[i] == m) 
                {                    
                    k++;
                    if(k==1) Console.Write("Номера элементов равных М: ");
                    Console.Write(i + 1 + " ");

                }
            }
            Console.WriteLine();

            Console.Write("Количество элементов равных М =  " + k);

           Console.ReadKey();
        }

    }
}