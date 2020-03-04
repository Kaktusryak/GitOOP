using System;

namespace OOP2_DLL_
{
    public class MyString
    {

        public string text;//змінна що виконує роль тексту

        public void Init()//функція створення тексту
        {
            text = Console.ReadLine();


        }
        public string get()//функція отримання тексту
        {
            return text;
        }
    };

    public class ChangeString
    {



        public string add(string a, string b)//функція об'єднання тексту
        {
            return a + b;
        }

        public string deletes(string add2, int n, int m)//функція видалення частини тексту
        {
            string del = add2.Remove(n, m);
            return del;
        }
        public string deleteall(string add4)//функція видалення всього рядка
        {
            return add4.Remove(0);

        }
        public int sizes_with_spases(string add5)//функція підрахунку розміру включно з пробілами
        {
            return add5.Length;
        }
        public int sizes(string add6)//функція підрахунку розміру не рахуючи пробілів
        {
            int g = add6.Length;
            int c = 0;
            const char s = ' ';
            for (int i = 0; i < g; i++)
            {
                if (add6[i] != s)
                {
                    c++;
                }
            }
            return c;
        }
        public int search(string add7, string h)//функція пошуку
        {
            int l = 0;
            for (int i = 0; i < add7.Length; i++)
            {
                if (add7[i] == h[0])
                {
                    l++;
                }
            }
            return l;
        }
        public string replace(string add8, string r, string p)//функція заміни символа
        {
            return add8.Replace(r[0], p[0]);
        }


    };
}
