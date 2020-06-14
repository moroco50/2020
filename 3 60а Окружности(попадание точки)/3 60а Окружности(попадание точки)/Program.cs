using System;

namespace _3_60а_Окружности_попадание_точки_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите M(X)");
            double mx;
            bool ok;

            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out mx);
                if (!ok) Console.WriteLine("Это не число ");
            } while (!ok);
            Console.WriteLine("Введите M(Y)");
            double my;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out my);
                if (!ok) Console.WriteLine("Это не число ");
            } while (!ok);
            double ox = 0;
            double oy = 0;
            double r = 2;
            double r1 = 1;
            if ((mx == 0) && (my >= 1) && (my <=2)) Console.WriteLine("U = " + mx + " (Вне фигуры)");
            else if ((mx > 0 && my > 0 && mx <= 2 && my <= 2) || (mx < 0 && my > 0 && mx >= -2 && my <= 2))
            {
                double d = Math.Sqrt(Math.Pow(ox - mx, 2) + Math.Pow(oy - my, 2));
                if ((d < r && d > r1) || (d == r || d == r1)) Console.WriteLine("U = 0");
                else Console.WriteLine("U = " + mx);
            }
            else Console.WriteLine("U = " + mx);
        }
    }
}
