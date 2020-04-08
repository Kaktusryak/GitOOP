// OOP5_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _USE_MATH_DEFINES
#define M_PI
#include <iostream>
#include <cmath>

using namespace std;



class Figures//загальний клас
{
public: virtual double Area()//віртуальні функції
{
    return 0;
}
      virtual double Perimeter()
      {
          return 0;
      }
};
class Rombs :Figures//похідний клас
{
public: double x1, x2, x3, x4, y1, y2, y3, y4;//координати ромба
     Rombs(double X1, double X2, double X3, double X4, double Y1, double Y2, double Y3, double Y4)//конструктор визначення координат ромба
    {
        x1 = X1;
        x2 = X2;
        x3 = X3;
        x4 = X4;
        y1 = Y1;
        y2 = Y2;
        y3 = Y3;
        y4 = Y4;
    }
     double Area()//метод пошуку площі ромба
    {
        double d1 = sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2));
        double d2 = sqrt(pow(x4 - x2, 2) + pow(y4 - y2, 2));
        return d1 * d2 / 2;
    }
     double Perimeter()//метод пошуку периметра ромба
    {
        double AB = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
        double BC = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
        double CD = sqrt(pow(x4 - x3, 2) + pow(y4 - y3, 2));
        double DA = sqrt(pow(x1 - x4, 2) + pow(y1 - y4, 2));
        return AB + BC + CD + DA;
    }

};
class Circles : Figures//похідний клас
{
public: double r;//радіус кола
     double pi = M_PI;//пі
     Circles(double R)//конструктор з визначенням радіусу
    {
        r = R;
    }
      double Area()//метод пошуку площі
    {
        return pi * pow(r, 2);
    }
      double Perimeter()//метод пошуку периметра
    {
        return 2 * pi * r;
    }
};

int main()
{
    cout << "Shulman Denis IS-92 Var 15 " << endl << "Enter data:";
    cout<<"x1(Romb): ";//дані
    double x1;
    cin >> x1;
    cout << "x2(Romb): ";
    double x2;
    cin >> x2;
    cout <<"x3(Romb): ";
    double x3;
    cin >> x3;
    cout << "x4(Romb): ";
    double x4;
    cin >> x4;
    cout << "y1(Romb): ";
    double y1;
    cin >> y1;
    cout << "y2(Romb): ";
    double y2;
    cin >> y2;
    cout << "y3(Romb): ";
    double y3;
    cin >> y3;
    cout << "y4(Romb): ";
    double y4;
    cin >> y4;
    cout << "r(Circle): ";
    double r;
    cin >> r;
    Rombs Romb1(x1, x2, x3, x4, y1, y2, y3, y4);//визначення об'єкту ромб
    Circles Circle1(r);//визначеня об'єкту коло
    double areaR = Romb1.Area();//площа ромба
    cout << "areaR = " <<  areaR<< endl;
    double areaC = Circle1.Area();//площа кола
    cout << "areaC = "<<  areaC<<endl;
    double perR = Romb1.Perimeter();//периметр ромба
    cout << "perR = "<< perR<<endl;
    double perC = Circle1.Perimeter();//периметр кола
    cout << "perC = "<< perC<<endl;
    
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
