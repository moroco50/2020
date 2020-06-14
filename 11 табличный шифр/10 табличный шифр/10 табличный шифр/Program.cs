using System;
using System.Globalization;

namespace _10_табличный_шифр
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok= false;

            char[] arr = new char[] { 'a', 'b', 'c', 'd', 'e',
                'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
            'P','Q','R','S','T','U','V','W','X','Y','Z' };
            char[] arr1 = new char[] { 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                       'a', 'b', 'c', 'd', 'e','f', 'g', 'h', 'i', 'j','k',
                                       'l', 'm', 'n', 'o', 'P','Q','R','S','T','U','V','W',
                                       'X','Y','Z', 'A','B','C','D','E','F', 'G','H','I','J',
                                       'K','L','M','N','O'};

            Console.WriteLine("Таблица шифрования: ");

            for (int i=0;i<arr.Length;i=i+4)
            {
                Console.WriteLine(" " + arr[i] + " => " + arr1[i] + "   " + arr[i + 1] + " => " + arr1[i + 1] + "   " + arr[i + 2] + " => " + arr1[i + 2] + "   " + arr[i + 3] + " => " + arr1[i + 3]);
                
            }

            /*for (int i = 0; i < mas.Length; i++)
            {
                 int a = Convert.ToInt32(char.GetNumericValue(mas[i])) + 5;
                 mas1[i] = a;
            }*/

            do
            {
                try
                {
                    Console.WriteLine("Введите текст: ");
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (!ok);

            string buf = Console.ReadLine();
            char[] mas = buf.ToCharArray();
            char[] mas1 = new char [buf.Length];


            Console.WriteLine("Зашифрованный текст: ");
            for (int i = 0; i < mas.Length; i++)
            {
                bool ok8 = false;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (mas[i] == arr[j]) 
                    {                        
                        mas1[i] = arr1[j];                        
                        ok8 = true;
                        continue;
                    }                     
                }
                if (!ok8) mas1[i] = mas[i];
                
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas1[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Расшифрованный текст: ");

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (mas1[i] == arr1[j]) mas[i] = arr[j];
                }
            }
           
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);
            }
        }
    }
}
