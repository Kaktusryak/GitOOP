using System;

namespace ConsoleApp1
{
    class Work
    {
        private int g;//кількість голосних
        public const char a = 'a';//набір голосних
        public const char e = 'e';
        public const char u = 'u';
        public const char o = 'o';
        public const char y = 'y';
        public const char i = 'i';
        private string[] Text= new string[5];//масив рядків (Текст)
        public int G //Властивість для кількості голосних
        {
            get {//тільки на виведення
                return g;
                }
        }
        


        public void Init()//функція створення тексту
        {
            for(int i = 0; i < 5; i++)//створення тексту з 5 рядків
            {
                Console.WriteLine("Enter string number {0}", i+1);
                Text[i] = Console.ReadLine();
            }
        }
        public int CountVow()//Підрахунок кількості голосних
        {
            for (int i = 0; i < 5; i++)
            {
                char[] f = Text[i].ToCharArray();//перехід з стрінг до масиву символів
                foreach(char k in f)//для кожного
                {
                    if (k == a || k == e || k == y || k == u || k == i || k == o)
                    {
                        g++;
                    }
                }
            }
            return 0;
        }
        public int this[int i] //індексатор (вибір рядка тексту
        {
            get//тіьки для повернення
            {
                return Text[i].Length;
            }
        }

    }
    class OOP3cs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 var 15");
            Work work = new Work();//створення об'єкту
            work.Init();//створення тексту
            Console.Write("Enter line(1--5):");
            int n;//номер рядка для підрахунку літер
            n = Convert.ToInt32(Console.ReadLine());
            n--;
            int t;
            t = work[n];//кількість літер записана в т
            Console.WriteLine("Length of string:{0}", t);
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            work.CountVow();//підрахунок голосних
            int h = work.G;//передача через властивість кількості голосних
            Console.WriteLine("Amount of vowes:{0}", h);



        }
    }
}
