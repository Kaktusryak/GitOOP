// pch.h: это предварительно скомпилированный заголовочный файл.
// Перечисленные ниже файлы компилируются только один раз, что ускоряет последующие сборки.
// Это также влияет на работу IntelliSense, включая многие функции просмотра и завершения кода.
// Однако изменение любого из приведенных здесь файлов между операциями сборки приведет к повторной компиляции всех(!) этих файлов.
// Не добавляйте сюда файлы, которые планируете часто изменять, так как в этом случае выигрыша в производительности не будет.

#ifndef PCH_H
#define PCH_H

// Добавьте сюда заголовочные файлы для предварительной компиляции
#include "framework.h"
#include <iostream>
#include <stdio.h>
#include <string>
using namespace std;
namespace Space {
	class MyString
	{
	private:
		string text;//змінна що виконує роль тексту
	public:
		void Init();//функція створення тексту
		string get();//функція отримання тексту
	};

	class ChangeString
	{

	public:
		string add(string, string);//функція об'єднання тексту
		string deletes(string, int, int);//функція видалення частини тексту
		string deleteall(string);//функція видалення всього рядка
		int sizes_with_spases(string);//функція підрахунку розміру включно з пробілами
		int sizes(string);//функція підрахунку розміру не рахуючи пробілів
		int searchs(string, char);//функція пошуку
		string replace(string, char, char);//функція заміни символа

	};

}
#endif //PCH_H
