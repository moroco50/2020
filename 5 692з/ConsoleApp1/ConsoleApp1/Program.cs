using System;

namespace ConsoleApplication10

    {

        class Program

        {

            static void Main(string[] args)

            {

                int N;
                bool ok;

                Console.WriteLine("Введите размер матрицы");

                do
                {

                    string buf = Console.ReadLine();

                    ok = int.TryParse(buf, out N);

                    if (!ok || N < 0) { Console.WriteLine("Введите целое положительное значение"); ok = false; }

                } while (!ok);
            
            int i = N;
            int j = N;

            int [,] A= new int[i,j];

            Random random = new Random();

            for (i=0; i<N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = random.Next(-100, 100);

                    Console.Write("{0,4}", A[i, j]);
                }
                Console.WriteLine();
             }

            int mas = A[0,N - 1];

            for (i = 0; i <= (N - 1) / 2; i++)
            {
                for (j = (N - 1); j >= (N - 1) - i; j--)
                {
                    if (A[i, j] > mas)
                    {
                        mas = A[i, j];
                    }
                }
            }

            for (i = (N - 1) / 2; i < N; i++)
            {
                for (j = (N - 1); j >= i; j--)
                {
                    if (A[i, j] > mas)
                    {
                        mas = A[i, j];
                    }
                }
            }

            Console.WriteLine("Наибольшее значение области: " + mas);  

            }
        }
}