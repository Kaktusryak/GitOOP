using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5cs
{
    class First//перший клас 
    {

        public string Text { get; set; }//властивість - текст

        public First(string intext) //конструктор привласнення текту значення
        {
            Text = intext;
        }
        public int Size()//метод визначення довжини тексту
        {
            return Text.Length;
        }
    }
    class Second : First//похідний другий клас
    {

        

        public Second( string intext)//конструтор, що походить від першого класу
            : base(intext) { }//використання батьківського класу
        
        public void Sort()//метод сортування тексту в спаданні
        {
            
            char[] sReverse = Text.ToCharArray();
            int dif;
            for(int i = 0; i < sReverse.Length-1; i++)
            {
                for(int j = 0; j < sReverse.Length-1; j++)
                {
                    dif = sReverse[j].CompareTo(sReverse[j + 1]);
                    if (dif < 0)
                    {
                        char s;
                        s = sReverse[j + 1];
                        sReverse[j + 1] = sReverse[j];
                        sReverse[j] = s;
                    }
                   
                }
            }
            
            Text = new string(sReverse);
            
        }
        public void Print()//метод виведення
        {
            Console.WriteLine(Text);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 Var 15");
            Console.WriteLine("Enter data(text):");
            string text = Console.ReadLine();//текст

            First Text0 = new First(text);//створення об'єкту першого класу

            int L = Text0.Size();//довжина тексту 1
            Console.WriteLine("Length of 1");
            Console.WriteLine(L);

            Second Text2 = new Second(text);//створення об'єкту другого класу
            Text2.Sort();//сортування тексту другого об'єкту
            int L2 = Text2.Size();//довжина тексту другого об'єкту
            Console.WriteLine("Length of 2");
            Console.WriteLine(L2);
            Console.WriteLine("Text");
            Text2.Print();//виведення+


            Console.ReadKey();

        }
    }
}
