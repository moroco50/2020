using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            bool ok=false;
            Console.WriteLine("Введите кол-во вершин");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok || n < 1)
                { 
                    Console.WriteLine("Введите целое положительное значение");
                    ok = false;
                }
                //if (n>6 || n < 2) Console.WriteLine("2 <= N <= 6");
            } while (!ok);

            Console.WriteLine("Введите кол-во ребер");
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out m);
                if (!ok || m < 1) Console.WriteLine("Введите целое положительное значение");
            } while (!ok);
            int[,] mas = new int[n, m];
            mas = InputMas2(n, m);

            Console.Clear();
            Console.WriteLine("Введенная матрица инцидентности: ");
            for (int i = 0; i < n; i++)
            {                
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas[i, j]);                    
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int k = 0;
                int j1 = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] == 1)
                    {
                        k++;
                        j1 = j;
                    }
                }
                int j2=0;
                if (j1 == 2) j2 = 2;
                else if (j1 == 3) j2 = 2;
                if (k == 1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mas[i, j] == 1)
                        {
                            mas[i, j] = 0;
                        }
                    }
                    Console.WriteLine((j2) + "-" + (i + 1) + " мост");
                    if(j2>1 && j1 >1) mas[j2-1, j1-1] = 0;
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                int j1 = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] == 1)
                    {
                        k++;
                        j1 = j;
                    }
                }
                int j2 = 0;
                if (j1 == 2) j2 = 2;
                else if (j1 == 3) j2 = 2;
                if (k == 1) Console.WriteLine((j2) + "-" + (i + 1) + " мост");
                mas[i, j1] = 0;
            }
        }


        #region ввод матрицы
        static int[,] InputMas2(int n, int m)
        {
            int[,] mas = new int[n, m];
            ; for (int i = 0; i < n; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ввод " + (i+1) +" строки: ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Введите элемент массива");
                    mas[i, j] = InputNumber(); 
                }
            }
            return mas;
        }

        static int InputNumber()
        {
            int a = -1;
            bool ok = false;
            do
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка");
                }
                if (a > 1 || a < 0)
                {
                    ok = false;
                    Console.WriteLine("Введите 0 или 1");
                }
            } while (!ok);
            return a;
        }
        #endregion
    }
}
