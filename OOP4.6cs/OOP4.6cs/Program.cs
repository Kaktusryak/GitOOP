using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4cs
{
    class Koord
    {


        public static Koord operator *(Koord Z3, int a)//перевантаження оператора множення
        {
            Koord result = new Koord();
            try
            {
                result.length = Z3.length * a;
                if (Z3.length == 0)
                {
                    throw new Exception("WARNING!!! (length is 0 while trying to double length)");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return result;
        }
        public static Koord operator +(Koord Z2, Koord Z3)//перевантаження оператора додавання
        {
            Koord result1 = new Koord();
            double pi = Math.PI;
            double a2 = Z2.angle * pi / 180;
            double a3 = Z3.angle * pi / 180;
            result1.length = Math.Sqrt(Math.Pow(Z2.length, 2) + Math.Pow(Z3.length, 2) - 2 * Z2.length * Z3.length * Math.Cos(a2 - a3 + pi));
            result1.angle = Math.Asin(Math.Sin(a2 + pi - a3) * (Z3.length) / result1.length) - a2;
            result1.angle = result1.angle * 180 / pi;
            return result1;
        }






        private double length;//довжина
        private double angle;//кут


        public Koord()//конструктор з даними за замовчуванням
        {
            length = 0;
            angle = 30;
        }
        public Koord(double l, double a)//конструктор з даними,що вводяться
        {
            length = l;
            angle = a;
        }
        public Koord(Koord ob)//конструктор копіювання
        {
            length = ob.length;
            angle = ob.angle;
        }

        public void Print()//метод виведення
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Angle: {0}", angle);
        }
        public void Turn(int w)//метотд повороту на 90 градусів
        {
            if (w == 0)
            {
                angle -= 90;
            }
            if (w == 1)
            {
                angle += 90;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 var 15");
            Console.Write("Enter length of Z2:");
            double l2 = Convert.ToInt32(Console.ReadLine());//довжина другого об'єкту
            Console.Write("Enter angle of Z2:");
            double a2 = Convert.ToInt32(Console.ReadLine());//кут другого об'єкту
            Koord Z2 = new Koord(l2, a2);//створення другого об'єкту
            Koord Z3 = new Koord();//створення третього об'єкту
            Console.WriteLine("Z2(by entered data) and Z3(by deffault data) before any changes:");
            Console.WriteLine("Z2:");
            Z2.Print();//виведення
            Console.WriteLine("Z3:");
            Z3.Print();
            Console.WriteLine("Z2(by entered data) and Z3(by deffault data) after length of Z3 was doubled:");


            Z3 = Z3 * 2;//множення на 2
            Console.WriteLine("Z2:");
            Z2.Print();
            Console.WriteLine("Z3:");
            Z3.Print();
            Console.WriteLine("Enter  1  if u want to +90 degrees and  0  if u want -90 degrees:");
            int w = Convert.ToInt32(Console.ReadLine());//вибір сторони обороту
            Z3.Turn(w);
            Console.WriteLine("Z2(by entered data) and Z3(by deffault data) after turning Z3 on 90 degrees  :");
            Console.WriteLine("Z2:");
            Z2.Print();
            Console.WriteLine("Z3:");
            Z3.Print();
            Koord Z1 = new Koord(Z2 + Z3);//перевантаження додавання у конструкторі каопіювання
            Console.WriteLine("Z2(by entered data) and Z3(by deffault data) and Z1(sum of Z2 and Z3)");
            Console.WriteLine("Z2:");
            Z2.Print();
            Console.WriteLine("Z3:");
            Z3.Print();
            Console.WriteLine("Z1:");
            Z1.Print();
            Console.ReadKey();
        }
    }
}
