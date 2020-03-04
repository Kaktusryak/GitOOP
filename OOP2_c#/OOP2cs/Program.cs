using System;
using OOP2_DLL_;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92");
            MyString New = new MyString();//створення об'єкту класу MyString
            MyString New2 = new MyString();//створення об'єкту класу MyString
            ChangeString Change = new ChangeString();//створення об'єкту класу ChangeString
            Console.WriteLine("Enter first part:");
            New.Init();//перша частина всього тексту
            Console.WriteLine("Enter second part:");
            New2.Init();//друга частина всього тексту
            string str1 = New.get();
            string str2 = New2.get();
            Console.WriteLine("No change: {0} | {1}", New.get(), New2.get());
            Console.WriteLine("First + second: {0}", Change.add(str1, str2));//об'єднання в один текст

            string Add2 = Change.add(str1, str2);
            string Add3 = Add2;//рядок для видалення з х до у
            string Add4 = Add2;//для видалення всього
            string Add5 = Add2;//для підрахунку з пробілами
            string Add6 = Add2;//для підрахунку без пробілів
            string Add7 = Add2;//для пошуку
            string Add8 = Add2;//для заміни

            Console.Write("Delete From:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());//індекс першого символу видалення
            Console.Write("How much do u want to delete?:");
            int m;
            m = Convert.ToInt32(Console.ReadLine());//штдекс останньогоо символу видалення
            Console.WriteLine("String with deleted part: {0}", Change.deletes(Add2, n, m));//видалена частина рядку
            string del = Change.deleteall(Add4);//увесь видалений текст
            Console.WriteLine("Deleted string(Add4): //{0}//", del);
            int k = Change.sizes_with_spases(Add5);//кількість з пробілами
            Console.WriteLine("Size of string including spases: {0}", k);
            int c = Change.sizes(Add6);//кількість без пробілів
            Console.WriteLine("Size of string without spases: {0}", c);

            string r, p;
            Console.WriteLine("Enter symbol u need to replace:");
            r = Console.ReadLine();//символ що буде замінений

            Console.WriteLine("Enter symbol enother symbol should be replaced with:");
            p = Console.ReadLine();//символ на який буде замінений попередній

            string v = Change.replace(Add8, r, p);
            Console.WriteLine("Text with replaced symbols: {0}", v);
            Console.Write("Enter symbol u need to find:");
            string h;//символ що потрібно знайти
            h = Console.ReadLine();
            int j = Change.search(Add7, h);//символ що потрібно знайти
            Console.WriteLine("Amount of symbols u need to find is: {0}", j);
            Console.ReadKey();
        }











    }
}
