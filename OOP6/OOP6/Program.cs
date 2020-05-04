using System;
using static System.Exception;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    
    class Data
    {
        private double a;//змінні виразу
        private double b;
        private double c;

        public Data(double A, double B, double C)//конструктор присвоєння змінним даних
        {
            a = A;
            b = B;
            c = C;
        }
        public double Method()//основний метод
        {
            try//спроба обрахунку
            {
                double t;
                t = (Math.Log(a * b + 2) * c) / (42 - (b / c));//вираз
                
                if ((a * b + 2) <= 0)//викид першого виключення з від'ємним аргументом логарифму
                {
                    throw new LOGException("WARNING!!! in log(x) x is below(or is) zero");
                }
                if ((42 - (b / c) == 0))//викид виключення з знаменником 0
                {
                    throw new DivideByZeroException("WARNING!!! denominator is zero");
                }
                if (c == 0)//викид виключення з знаменником 0
                {
                    throw new DivideByZeroException("WARNING!!! denominator is now zero");
                }

                return t;
            }
            catch (DivideByZeroException exc)//знаменник 0
            {
                Console.WriteLine(exc);
                return 0;
            }
            catch (LOGException exc)//вилов другого виключення з від'ємним аргументом логарифму
            {
                Console.WriteLine(exc);
                return 0;
            }
            


            

        }
        class LOGException : Exception//власний клас виключень
        {
            public LOGException() : base() { }
            public LOGException(string str) : base(str) { }
            public LOGException(string str, Exception inner) : base(str, inner) { }
            protected LOGException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
            public override string ToString() { return Message; }//перевантаження ToString
        }
    }
    class Program
        {
            
            static void Main(string[] args)
            {
            Console.WriteLine("Denis Shulman IS-92 Var 15");
            Data[] data= new Data[4];// масив об'єктів з різними даними, що можуть викликати виключення
            
            data[0] = new Data(-2, 2, 1);
            data[1] = new Data(2, 42, 1);
            data[2] = new Data(10, 10, 10);
            data[3] = new Data(10, 10, 0);
            Console.WriteLine("Element #0");
            Console.WriteLine (data[0].Method());
            Console.WriteLine("Element #1");
            Console.WriteLine(data[1].Method());
            Console.WriteLine("Element #2");
            Console.WriteLine(data[2].Method());
            Console.WriteLine("Element #3");
            Console.WriteLine(data[3].Method());
            Console.ReadKey();
            }
        }
    }

