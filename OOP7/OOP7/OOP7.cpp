#include <iostream>

using namespace std;

#include <conio.h>
#include <iostream>

struct element                  //структура даних
{
    short x;                        //значення елементу
    element* Next;                 //адреса наступного елемементу

};

class List                      //Клас Список
{
    element* Head;                 //голова списку
public:
    List() { Head = NULL; }           //конструктор з ініціалізацією голови
                           
    void Add(short x);               //функція додавання значення в список
    void Show();                   //функція відображення списку
    void Count7Func();             //функція підрахунку кратних 7                                         
    void ToZero();                  //функція переназначення як нуль значень, що більше середнього                
private:
    int count;
};



void List::Add(short x) //функція додавання значення в список
{
    element* temp = new element;           //виділення нової комірки
    temp->x = x;                            //запис значення
    temp->Next = Head;                      //наступний - голова
    Head = temp;                            //останній - тільки що введений
}



void List::Show()                       //функція відображення списку
{
    element* temp = Head;                 //виділяємо покажчик на перший елемент

    
    while (temp != NULL)                   //до кінця
    {
        cout << temp->x << " ";               //виведення значення
        temp = temp->Next;                    //перехід на наступний
    }
}
void List::Count7Func()                       //функція підрахунку кратних 7    
{
    element* temp = Head;                 //виділяємо покажчик на перший елемент



    while (temp != NULL)                    //до кінця
    {
        if ((temp->x % 7) == 0) {
            count++;
        }

        temp = temp->Next;                    //перехід на наступний
    }
    cout << "Count = " << count << endl;
}
void List::ToZero()                       //функція переназначення як нуль значень, що більше середнього
{
    element* temp = Head;                 //виділяємо покажчик на перший елемент
    short c = 0;                        //сума
    short n = 0;                        //кількість

    while (temp != NULL)                   //до кінця
    {
        c += temp->x;              
        temp = temp->Next;                    //перехід на наступний
        n++;
    }
    short t = c / n;                        //середнє
    element* temp1 = Head;
    while (temp1 != NULL)                  //до кінця
    {
        if (temp1->x > t) {                 //більше середнього
            temp1->x = 0;
       }
        temp1 = temp1->Next;                //перехід на наступний
    }
   
}


int main()
{
    cout << "Denis Shulman IS-92 Var 15" << endl;
    List L;//ініціалізація списку
    L.Add(7);//дозапис елементу
    L.Add(5);//дозапис елементу
    L.Add(7);//дозапис елементу
    L.Show();//виведення
    cout << endl << "%7==0:" << endl;
    L.Count7Func();//підрахунок кратних 7
    cout << "After change :" << endl;
    L.ToZero();//більше середнього = 0
    L.Show();//виведення



    cin.get();
    return 0;
}