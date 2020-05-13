using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8cs
{
    class Text
    {
        
       
        
        public Text(string Line, char A)//конструктор
        {
            line = Line;
            a = A;
        }
        public string line { get; set; }//рядок(текст)
        public char a;//шукана літера
        public void SearchL()//екземплярна функція
        {
            for(int i = line.Length-1;i>= 0;i--)
            {
                if (line[i] == a)
                {
                    Console.WriteLine("Number of {1} is {0}", i+1, a);
                    break;
                }
            }
        }
        public static void SearchLO(string line2, char a2)//статична функція
        {
            for (int i = line2.Length - 1; i >= 0; i--)
            {
                if (line2[i] == a2)
                {
                    Console.WriteLine("Number of {1} is {0}", i+1, a2);
                    break;
                }
            }
        }

    }

    class Program
    {
        public delegate void Delegate(string line, char a);//делегат
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 Var 15");
            Text text1 = new Text("asasfasdfasfasfasf", 'a');
            text1.SearchL();//виклик екземплярної версії
            Text.SearchLO("asasfasdfasfasfasf", 'a');//виклик статичної версії
            Delegate del = new Delegate(Text.SearchLO);//створення делегату та передача в нього статичної функції(застарілий варіант)
            if(del != null)//перевірка на порожній делегат та виклик(після проходження перевірки
            {
                del("asasfasdfasfasfasf", 'a');
            }
            
            


            Console.ReadKey();
        }
    }
}
