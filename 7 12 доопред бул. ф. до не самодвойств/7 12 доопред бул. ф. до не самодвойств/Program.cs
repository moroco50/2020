using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace _7_12_доопред_бул._ф._до_не_самодвойств
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok;            
            int[] mas = new int[8];
            int x = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("f(" + Convert.ToString(x, 2).PadLeft(3, '0') + ") = ");                
                int s;                
                do
                {
                    bool ok1=false;
                    string buf = Console.ReadLine();
                    ok = int.TryParse(buf, out s);    
                    if (buf == "*")
                    {
                        ok1 = true;
                        mas[i] = 2;
                        x++;
                        ok = true;
                        continue;
                    }

                    if (!ok)
                    {
                        Console.WriteLine("Введите целое число от 0 до 1");
                        Console.Write("f(" + Convert.ToString(x, 2).PadLeft(3, '0') + ") = ");
                    }

                    if (s < 0 || s > 1 || buf.Length > 1)
                    { 
                        Console.WriteLine("Введите целое число от 0 до 1"); 
                        ok = false;
                        Console.Write("f(" + Convert.ToString(x, 2).PadLeft(3, '0') + ") = ");
                    }     

                    if (ok || ok1)
                    {
                        mas[i] = Convert.ToInt32(s);
                        x++;
                    }
                } while (!ok);                
            }

            Console.WriteLine();
            Console.Write("f(xyz) = ");

            for (int i=0;i<mas.Length;i++)
            {
                if (mas[i]==2) Console.Write("* ");
                else Console.Write(mas[i] + " ");
            }
            Console.WriteLine();

            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                if (mas[i] == mas[mas.Length-i-1]) k++;
                
            }

            if (k == 4) Console.WriteLine("Вы ввели определенную самодвойсвенную функцию");
            else
            {
                k = 0;
                int k1 = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == 2) k++;
                    if (mas[i] == 1 || mas[i] == 0) k1++;

                }

                if (k == 0 && k1 != 0) Console.WriteLine("Вы ввели определенную не самодвойсвенную функцию");
            }

            for (int i = 0; i < mas.Length / 2; i++)
            {

                if (mas[i] == 2 && mas[mas.Length - i-1] != 2)
                {
                    if (mas[mas.Length - i-1] == 1) mas[i] = 1;
                    else mas[i] = 0;
                }

                if (mas[i] == 2 && mas[mas.Length - i-1] == 2)
                {
                    mas[i] = 1; mas[mas.Length - i-1] = 0;
                }
            }

            for (int i = 3; i < mas.Length; i++)
            {
                if (mas[i] == 2 && mas[mas.Length - i-1] != 2)
                {
                    if (mas[i] == 1) mas[mas.Length - i-1] = 1;
                    else mas[i] = 0;
                }
            }

            // вывод вектора
            Console.Write("f(xyz) = ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
    }
}