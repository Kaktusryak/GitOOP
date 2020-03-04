// StaticLib1.cpp : Определяет функции для статической библиотеки.
//

#include "pch.h"
#include "framework.h"

// TODO: Это пример библиотечной функции.
#include <iostream>
#include <stdio.h>
#include <string>
using namespace std;
namespace Space {
	void MyString::Init()//функція створення тексту
	{
		getline(cin, text);
	}

	string MyString::get()//функція отримання тексту
	{
		return text;
	}

	string ChangeString::add(string a, string b)//функція об'єднання тексту
	{
		return a + b;
	}
	string ChangeString::deletes(string add2, int n, int m) {//функція видалення частини тексту
		string del = add2.erase(n, m);
		return del;
	}
	string ChangeString::deleteall(string add4) {//функція видалення всього рядка
		add4.clear();
		return add4;

	}
	int ChangeString::sizes_with_spases(string add5) {//функція підрахунку розміру включно з пробілами

		return size(add5);
	}
	int ChangeString::sizes(string add6) {//функція підрахунку розміру не рахуючи пробілів
		int g = size(add6);
		int c = 0;
		const char s = ' ';
		for (int i = 0; i < g; i++) {
			if (add6[i] != s) {
				c++;
			}
		}
		return c;

	}

	int ChangeString::searchs(string add7, char h) {//функція пошуку


		int l = 0;
		for (int i = 0; i < size(add7); i++) {
			if (add7[i] == h) {
				l++;
			}


		}
		return l;
	}
	string ChangeString::replace(string add8, char r, char p) {//функція заміни символа
		for (int i = 0; i < size(add8); i++) {
			if (add8[i] == r) {
				add8[i] = p;
			}
		}
		return add8;
	}



}
