#include <iostream>
#include <stdio.h>
#include <string>
#include "../StaticLib1/pch.h"
using namespace Space;
using namespace std;



int main()
{
	cout << "Denis Shulman IS-92" << endl;
	
	MyString New;//створення об'єкту класу MyString
	MyString New2;//створення об'єкту класу MyString
	ChangeString Change;//створення об'єкту класу ChangeString
	cout << "Enter first part:";
	New.Init();//перша частина всього тексту
	cout << "Enter second part:";
	New2.Init();//друга частина всього тексту
	string str1 = New.get();
	string str2 = New2.get();
	cout << "No change: " << New.get() << "|" << New2.get() << endl;
	cout << "First + second: " << Change.add(str1, str2) << endl;//об'єднання в один текст
	string Add2 = Change.add(str1, str2);
	string Add3 = Add2;//рядок для видалення з х до у
	string Add4 = Add2;//для видалення всього
	string Add5 = Add2;//для підрахунку з пробілами
	string Add6 = Add2;//для підрахунку без пробілів
	string Add7 = Add2;//для пошуку
	string Add8 = Add2;//для заміни
	
	cout << "Delete From:";
	int n;//індекс першого символу видалення
	cin >> n;
	cout << "Delete To:";
	int m;//штдекс останньогоо символу видалення
	cin >> m;
	cout << "String with deleted part: " << Change.deletes(Add2, n, m) << endl;//видалена частина рядку
	string del = Change.deleteall(Add4);//увесь видалений текст
	cout << "Deleted string(Add4): //" << del << "//" << endl;
	int k = Change.sizes_with_spases(Add5);//кількість з пробілами
	cout << "Size of string including spaces:" << k << endl;
	int c = Change.sizes(Add6);//кількість без пробілів
	cout << "Size of string without spaes:" << c << endl;

	char r, p;
	cout << "Enter symbol u need to replace:";
	cin >> r;//символ що буде замінений
	cout << "Enter symbol enother symbol should be replaced with:";
	cin >> p;//символ на який буде замінений попередній
	string v = Change.replace(Add8, r, p);
	cout << "Text with replaced symbols:" << endl << v << endl;
	cout << "Enter symbol u need to find:";
	cin.ignore(32767, '\n');//очищення поля введення
	char h;
	cin >> h;//символ що потрібно знайти
	int j = Change.searchs(Add7, h);//символ що потрібно знайти
	cout << "Amount of symbol u need to find is: " << j << endl;




}

