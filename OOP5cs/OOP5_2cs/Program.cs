using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_2cs
{
    class Figures//батьківський клас
    {
        public virtual double Area()//віртуальна функція пошуку площі
        {
            return 0;
        }
        public virtual double Perimeter()//віртуальна функція пошуку периметра
        {
            return 0;
        }
    }
    class Rombs:Figures
    {
        protected double x1, x2, x3, x4, y1, y2, y3, y4;//координати ромба
        public Rombs(double X1, double X2, double X3, double X4,double Y1, double Y2, double Y3, double Y4)//конструктор заповнення координат ромба
        {
            x1 = X1;
            x2 = X2;
            x3 = X3;
            x4 = X4;
            y1 = Y1;
            y2 = Y2;
            y3 = Y3;
            y4 = Y4;
        }
        override public double Area()//віртуальна функція пошуку площі
        {
            double d1 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double d2 = Math.Sqrt(Math.Pow(x4 - x2, 2) + Math.Pow(y4 - y2, 2));
            return d1 * d2 / 2;
        }
        override public double Perimeter()//віртуальна функція пошуку периметра
        {
            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double CD = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            double DA = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));
            return AB + BC + CD + DA;
        }

    }
    class Circles : Figures//похідний клас кіл
    {
        public double r;//радіус
        double pi = Math.PI;//пі
        public Circles(double R)//конструктор з заданням радіусу
        {
            r = R;
        }
        override public double Area()//віртуальна функція пошуку площі
        {
            return pi * Math.Pow(r, 2);
        }
        override public double Perimeter()//віртуальна функція пошуку периметра
        {
            return 2 * pi * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 Var 15");
            Console.WriteLine("Enter data:");
            Console.Write("x1(Romb): ");//введення даних
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2(Romb): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3(Romb): ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x4(Romb): ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1(Romb): ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2(Romb): ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3(Romb): ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y4(Romb): ");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r(Circle): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Rombs Romb1 = new Rombs(x1, x2,x3, x4, y1, y2, y3, y4);//створення ромба
            Circles Circle1 = new Circles(r);//створення кола
            double areaR = Romb1.Area();//площа ромба
            Console.WriteLine("areaR ={0}", areaR);
            double areaC = Circle1.Area();//площа кола
            Console.WriteLine("areaC ={0}", areaC);
            double perR = Romb1.Perimeter();//периметр ромба
            Console.WriteLine("perR ={0}", perR);
            double perC = Circle1.Perimeter();//периметр кола
            Console.WriteLine("perC ={0}", perC);
            Console.ReadKey();
        }
    }
}
