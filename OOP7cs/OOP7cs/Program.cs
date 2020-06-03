using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7cs
{
    public class Node
    {
        private short _Data;//значення
        private Node _Next;//наступний
        
        public short Value//властивість значення
        {
            get { return _Data; }
            set { _Data = value; }
        }
        public Node(short Data)//конструктор запису даних
        {
            this._Data = Data;
        }
        public Node Next//наступний
        {
            get { return this._Next; }
            set { this._Next = value; }
        }

    }


    class List
    {
        private Node Head;//голова
       
        private int count;//кількість

        public List()//конструктор ініціалізації голови
        {
           
            Head  = null;
        }
        public void Add(short x)//додавання елементу
        {

            Node temp = new Node(x);//значення = х
            temp.Next = Head;//накступний - голова
            Head = temp;//останній той, що щойно введений

        }
        public void Show()//виведення елементу
        {
            Node temp = Head;//початок з голови
            while (temp != null)//до кінця
            {
                Console.Write(temp.Value);
                temp = temp.Next;//на наступний 
            }
            Console.WriteLine();
        }
        public void Count7Func()//функція підрахунку кратних 7 
        {
            Node temp = Head;//початок з голови
            while (temp != null) //до кінця                  
            {
                if ((temp.Value % 7) == 0)//якщо кратне 7
                {
                    count++;
                }

                temp = temp.Next;//на наступний
            }
            Console.WriteLine("Count = {0}", count);
            
        }
        public void ToZero()
        {
            Node temp = Head;//початок з голови
            short c = 0;//сума
            short n = 0;//кількість
            while (temp != null)//до кінця
            {
                c += temp.Value;
                n++;
                temp = temp.Next;//на наступний
            }
            int t = c / n;
            temp = Head;//знову початок з голови
            while (temp != null)//до кінця
            {
              if(temp.Value > t)
                {
                    temp.Value = 0;
                }
                temp = temp.Next;//на наступний
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 Var 15");
            List L = new List();//створення списку
            L.Add(7);//дозапис 
            L.Add(5);//дозапис 
            L.Add(7);//дозапис
            L.Show();//виведення
            Console.WriteLine("%7==0:");
            L.Count7Func();//кратні 7
            L.ToZero();//більші за середнє = 0
            Console.WriteLine("After change:");
            L.Show();//виведення
            Console.ReadKey();
        }
    }
}

