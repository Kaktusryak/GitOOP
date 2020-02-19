﻿// ConsoleApplication12.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int sum(int *, int);//функция суммы
void compare(int, int);//функция сравнения


int main()
{
	cout << " Denis Shulman IS-92(cpp)" << endl;

	int a;//первое число

	int b;//второе число
	int c;
	cout << "Enter first digit:" << endl;
	cin >> a;//ввод первого числа
	cout << "Enter second digit:" << endl;
	cin >> b;//ввод второго числа
	c = sum(&a, b);//сумма
	cout << "Sum is :" << c;
	compare(a, b);//сравнение


}
int sum(int * a, int b) {//функция суммы


	unsigned x, y, sum = 0, mask = 1;
	for (unsigned i = 0; i < 32; i++) {//32 -битовой формы длина 
		x = *a & mask;//через маску мы сравниваем биты а и х
		y = b & mask;
		if (x == 1 << i && y == 1 << i) {//сравнение битов х и у через и
			sum |= 1 << (i + 1);
		}
		else if (x == 1 << i || y == 1 << i) {//сравнение битов х и у через или
			sum |= 1 << i;
		}

		mask <<= 1;
	}
	return sum;

}
void compare(int a, int b) {//функция сравнения
	cout << endl;
	int com = b & ((a - b) >> 31) | a & (~(a - b) >> 31);// нахождение наибольшего числа методом сдвига
	cout << com << " is bigger" << endl;
	
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
