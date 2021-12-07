using System;

namespace Zadanie_delegati
{
    class Program
    {
        delegate double MyDelegate(double R);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус, затем нажмите Enter");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = new MyDelegate(DlinaOkrugnosti);
            myDelegate += PloshadKruga;
            myDelegate += ObemShara;
            myDelegate?.Invoke(r);
            Console.ReadKey();


           static double DlinaOkrugnosti(double R)
            {
                double d = 2 * Math.PI * R;
                Console.WriteLine($"Длина окружности равна {d}");
                return d;

            }
            static double PloshadKruga(double R)
            {
                double s = Math.PI * Math.Pow(R,2);
                Console.WriteLine($"Площадь круга равна {s}");
                return s;
            }
            static double ObemShara(double R)
            {
                double v = 4/3 * Math.PI * Math.Pow(R, 3);
                Console.WriteLine($"Объем шара равен {v}");
                return v;
            }


        }
    }
}
