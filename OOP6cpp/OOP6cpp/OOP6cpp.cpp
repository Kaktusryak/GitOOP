#include <iostream>
using namespace std;

class Data
{
private:
        double a;//змінні
        double b;
        double c;

public: Data(double A, double B, double C)//конструктор з записом даних
{
    a = A;
    b = B;
    c = C;
}
     
      double Method()//основний метод
      {
          try
          {
              double t;
              t = (log(a * b + 2) * c) / (42 - (b / c));//основний вираз

              if ((a * b + 2) <= 0)//перше виключення з від'ємним аргументом інтеграла
              {
                  throw 1;
              }
              if ((42 - (b / c) == 0))//виключення з знаменником 0
              {
                  throw 2;
              }
              if (c == 0)//виключення з знаменником 0
              {
                  throw 2;
              }
              return t;
          }
          catch (int i)//вилов виключеня
          {
              if (i == 1) {//інтеграл
                  cout << endl << "WARNING!!! x in log(x) is or below zero" << endl;
              }
              if (i == 2) {//знаменник
                  cout << endl << "WARNING!!! denominator is zero" << endl;
              }

              return 0;
          }






      }

};

int main()
{
    cout << "Denis Shulman IS-92 Var 15" << endl;
    Data data[4] = { Data(-2,2,1), Data(2,42,1),Data(10,10,10) , Data(10,10,0)};//масив елементів
    cout << "Element #0" << endl;
    cout << data[0].Method() << endl;//виведеня
    cout << "Element #1" << endl;
    cout << data[1].Method() << endl;
    cout << "Element #2" << endl;
    cout << data[2].Method() << endl;
    cout << "Element #3" << endl;
    cout << data[3].Method() << endl;
}