using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static int GetInt()
        {
            bool ok = false;
            int temp = 0;
            do
            {
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое число");
                }
            } while (!ok);
            return temp;
        }

        static int GetInt(int start, int finish)
        {
            bool ok = false;
            int temp = 0;
            do
            {
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                    if (temp > finish || temp < start) ok = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое число");
                }
            } while (!ok);
            return temp;
        }

        static List CreateList(int n)
        {
            return Itteration(n, null);
        }

        static List Itteration(int n, List prev)
        {
            if (n == 0) return null;            
            else
            {
                List Current = new List(n);
                Current.prev = prev;
                Current.next = Itteration(n-1, Current);
                return Current;
            }
        }

        static void ShowYourList(List elem)
        {
            if (elem != null)
            {
                elem.Show();
                ShowYourList(elem.next);
            }
        }

        static void Menu()
        {
            Console.WriteLine("1. Найти элемент в списке");
            Console.WriteLine("2. Удалить элемент списка");
            Console.WriteLine("3. Вывести список");
            Console.WriteLine("4. Выход");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во переменных");
            int n = GetInt();
            List Array = CreateList(n);
            ShowYourList(Array);
            Console.WriteLine();
            int Choice = 0;
            do
            {
                Menu();
                Choice = GetInt(1, 4);
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Введите элемент");
                        int SearchingValue = GetInt();
                        int k = SearchFor(1, SearchingValue, Array);
                        Console.WriteLine($"Искомый элемент имеет позицию {k}");
                        break;
                    case 2:
                        Console.WriteLine("Введите элемент");
                        int Delete = GetInt();
                        if (Delete > 1) DeleteElem(ref Array, Delete);
                        else Console.WriteLine($"Нельзя удалить элемент {Delete}");
                        Console.WriteLine();
                        break;
                    case 3:
                        ShowYourList(Array);
                        Console.WriteLine();
                        break;
                    case 4:
                        break;
                }
            } while (Choice != 4);
        }
        static int SearchFor(int number, int val, List a)
        {
            if (a.value == val) return number;
            else if (a == null)
            {
                Console.WriteLine("Такого элемента нет");
                return 0;
            }
            else return SearchFor(number + 1, val, a.next);
        }
        static void DeleteElem(ref List Array, int val)
        {
            SearchAndDelete(val, ref Array, Array.prev);
        }
        static void SearchAndDelete(int value, ref List curr, List prev)
        {
            if (curr == null)
            {
                Console.WriteLine("Такого элемента нет");
                return;
            }
            else if (curr.value == value)
            {
                if (curr.next != null) curr.next.prev = prev;
                if (prev.next != null || prev != null) prev.next = curr.next;

            }
            else SearchAndDelete(value, ref curr.next, curr);
        }
    }
}
