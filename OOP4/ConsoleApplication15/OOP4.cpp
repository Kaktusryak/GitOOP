// ConsoleApplication15.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>
#include <math.h>
using namespace std;

class Koord {
private:

    
    double length;//довжина
    double angle;//кут
public:
    Koord()//конструктор з даними за умовчуванням
    {
        length = 10;
        angle = 30;
    }
    Koord(double l, double a)//конструктор з даними, що вводяться
    {
        length = l;
        angle = a;
    }
    Koord(Koord& ob)//конструктор копіювання
    {
        length = ob.length;
        angle = ob.angle;
    }
    

    Koord operator* (Koord Z3)//перевантаження оператора множення
    {
        Koord temp;
        temp.length = Z3.length * 2;
        return temp;
    }
    Koord operator+(Koord Z2)//перевантаження оператора додавання
    {
        Koord result1;
        const double pi =M_PI;
        double a2 = Z2.angle * pi / 180;
        double a3 = angle * pi / 180;
        result1.length = sqrt(pow(Z2.length, 2) + pow(length, 2) - 2 * Z2.length * length * cos(a2 - a3 + pi));
        result1.angle = asin(sin(a2 + pi - a3) * (length) / result1.length) - a2;
        result1.angle = result1.angle * 180 / pi;
        return result1;
    }


    void Print()//метод виведення даних
    {
        cout << endl << length;
        cout << endl << angle;
    }
    void Turn(int w)//метод поворолту на 90 градусів
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
};


int main()
{
    cout << "Denis Shulman IS-92 var 15"<< endl;
    cout << "Enter length of Z2:" << endl;
    double l2;//довжина другого об'єкту
    cin >> l2;
    cout << endl<<"Enter angle of Z2:" << endl;
    double a2;//кут другого об'єкту
    cin >> a2;
    Koord Z2(l2, a2);//створеня другого об'єкту з введеними даними
    Koord Z3;//створення третьго об'єкту з даними за замовчуванням
    cout << endl<<"Z2(by entered data) and Z3(by deffault data) before any changes:" << endl;
    cout << endl<<"Z2:" << endl;
    Z2.Print();//виведення даних об'єкту
    cout <<endl <<  "Z3:" << endl;
    Z3.Print();
    cout <<endl<< "Z2(by entered data) and Z3(by deffault data) after length of Z3 was doubled:" << endl;


    Z3 = Z3.operator*(Z3);//множення на 2
    cout <<endl <<  "Z2:" << endl;
    Z2.Print();
    cout << endl<<"Z3:" << endl;
    Z3.Print();
    cout << endl<<"Enter  1  if u want to +90 degrees and  0  if u want -90 degrees:" << endl;
    int w;//вибір у яку сторону повернути об'єкт 3
    cin >> w;
    Z3.Turn(w);//поворот на 90 градусів
    cout << endl << "Z2(by entered data) and Z3(by deffault data) after turning Z3 on 90 degrees  :"<< endl;
    cout << endl<<"Z2:" << endl;
    Z2.Print();
    cout <<endl<< "Z3:" << endl;
    Z3.Print();

    Koord Z1;//створення першого об'єкту
    Z1 = (Z2 + Z3);//перевантаження оператора додавання і копіювання до першого об'єкту
    cout << "Z2(by entered data) and Z3(by deffault data) and Z1(sum of Z2 and Z3)"<< endl;
    cout <<endl<< "Z2:" << endl;
    Z2.Print();
    cout << endl<<"Z3:" << endl;
    Z3.Print();
    cout << endl<<"Z1:" << endl;
    Z1.Print();
    
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
