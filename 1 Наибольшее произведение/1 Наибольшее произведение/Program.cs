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

namespace _1_Наибольшее_произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader(@"input.txt");
            string s;
            string[] buf;
            s = f.ReadLine();            
            string GetFile = File.ReadAllText(@"input.txt");
            int[] mas;
            int n = Convert.ToInt32(s);
            s = f.ReadLine();
            buf = s.Split(' ');
            int n1 = Convert.ToInt32(buf.Length);
            if (n == n1)
            {
                mas = new int[buf.Length];
                for (int i = 0; i < buf.Length; i++)
                {
                    mas[i] = int.Parse(buf[i]);
                }
                f.Close();
                //поиск максимумов
                int max = -30001;
                int max1 = -30001;
                int max2 = -30001;
                int min = 30001;
                int min1 = 30001;
                int min2 = 30001;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] >= max) { max2 = max1; max1 = max; max = mas[i]; }
                    else if (mas[i] >= max1) { max2 = max1; max1 = mas[i]; }
                    else if (mas[i] >= max2) { max2 = mas[i]; }
                    if (mas[i] <= min) { min2 = min1; min1 = min; min = mas[i]; }
                    else if (mas[i] <= min1) { min2 = min1; min1 = mas[i]; }
                    else if (mas[i] <= min2) { min2 = mas[i]; }
                }
                long v = -27002700090001;
                long v1 = -27002700090001;
                long v2 = -27002700090001;
                if ((min < 0 && min1 < 0) && max >= 0)
                {
                   v = min * min1 * max;
                }               
                else 
                {
                   v1 = max * max1 * max2;
                }
                long v3=0;
                if (v >= v1 && v >= v2) { v3 = v; }
                else  if (v1 > v && v1 > v2) { v3 = v1; }   
                File.WriteAllText(@"output.txt", Convert.ToString(v));
                Console.Write(v3);
            }
            else
            {
                Console.WriteLine("Ошибка загрузки файла");
                f.Close();
            }
        }
    } 
}