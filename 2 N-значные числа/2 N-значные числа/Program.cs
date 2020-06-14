using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics;

namespace _2_N_значные_числа
{
    class Program
    {       
        static void Main(string[] args)
        {
            int N, k, num = -55;
            double a, b;
            StreamReader f = new StreamReader(@"input.txt");
            string s;
            s = f.ReadLine();
            N = Convert.ToInt32(s);
            if (N > 0 && N <= 10)
            {
                if (N == 1) File.WriteAllText(@"output.txt", 10 + " " + 0);
                else
                {
                    k = 0;
                    a = Math.Pow(10, N - 1);
                    b = Math.Pow(10, N);

                    for (int i = (int)a; i < b; i++)
                    {
                        if (Num(i))
                        {
                            k++;
                            if (k == 1) num = i;
                        }
                    }
                    //Console.WriteLine(k + " " + num);
                    File.WriteAllText(@"output.txt", k + " " + num);
                }
            }
            else
            {
                Console.WriteLine("Число должно попадать в диапазон: (0 < Число <= 10)");
                f.Close();
            }            
        }

        public static bool Num(int N)
        {
            int p, sum;
            p = 1;
            sum = 0;

            while (N > 0)
            {
                sum += N % 10;
                p *= N % 10;
                N /= 10;
            }

            if (p == sum) return true;

            return false;
        }
    }
}