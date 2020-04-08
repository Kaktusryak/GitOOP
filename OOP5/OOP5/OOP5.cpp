﻿// OOP5.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <string>
using namespace std;
class First//перший клас
{

public: string Text;//текст

    First(string intext)//конструктор з присвоєння значення тексту
{
    Text = intext;
}
      int Size()//метод з виведення розміру
      {
          int t = Text.size();
          return t;
      }
};
class Second :public First//другий клас, який є дочірнім відносно пешого
{



public: Second(string intext) :First(intext) {}//копіювання конструктора з першого
      

     void Sort()//сортування тесту за спаданням
    {

        
        int dif1, dif2,dif3;
        for (int i = 0; i < int(Text.size()) - 1; i++)
        {
            for (int j = 0; j < int(Text.size()) - 1; j++)
            {
                dif1 = int(Text[j]);
                dif2 = int(Text[j + 1]);
                dif3 = dif2 - dif1;
                if (dif3 > 0)
                {
                    char s;
                    s = Text[j + 1];
                    Text[j + 1] = Text[j];
                    Text[j] = s;
                }

            }
        }

       

    }
     void Print()//метод виведення
    {
         cout << Text;
    }
      
};

int main()
{
    cout << "Shulman Denis IS-92 Var 15 " << endl << "Enter data:";
    string text;//текст
    getline(cin,text);

    First Text0 (text);//задання об'єкту з даним текстом

    int L = Text0.Size();//довжина тексту 1
    cout << "Length of 1:";
    cout << L << endl;

    Second Text2(text);//задання об'єкту з даним текстом
    Text2.Sort();//сортування тексту 2 об'єкту
    cout << "Length of 2:";
    int L2 = Text2.Size();//довжина тексту 2
    cout << L2 << endl;;
    cout << "Text:";
    Text2.Print();//метод виведення


    
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
