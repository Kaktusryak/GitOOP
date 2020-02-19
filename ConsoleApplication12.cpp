// ConsoleApplication12.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int sum(int *, int);
void compare(int, int);


int main()
{
	cout << " Denis Shulman IS-92(cpp)" << endl;

	int a;

	int b;
	int c;
	cout << "Enter first digit:" << endl;
	cin >> a;
	cout << "Enter second digit:" << endl;
	cin >> b;
	c = sum(&a, b);
	cout << "Sum is :" << c;
	compare(a, b);


}
int sum(int * a, int b) {


	unsigned x, y, sum = 0, mask = 1;
	for (unsigned i = 0; i < 32; i++) {
		x = *a & mask;
		y = b & mask;
		if (x == 1 << i && y == 1 << i) {
			sum |= 1 << (i + 1);
		}
		else if (x == 1 << i || y == 1 << i) {
			sum |= 1 << i;
		}

		mask <<= 1;
	}
	return sum;

}
void compare(int a, int b) {
	cout << endl;
	int com = b & ((a - b) >> 31) | a & (~(a - b) >> 31);
	cout << com << " is bigger" << endl;
	/*int x = a;
	int y = b;
	int mask = 0;
	for (int i = 0; i < 32; i++) {
		a = a << 1;
		b = b << 1;
		if (a == mask && b != mask) {
			cout << endl << x << " < " << y << endl;
			break;
		}
		else {
			if (a != mask && b == mask) {
				cout << endl << x << " > " << y << endl;
				break;
			}

		}
		if (i == 31) {
			cout << endl << x << " = " << y << endl;
		}
	}

	*/
	/*int e1 = ~a;
	int e2 = ~b;
	if (e1 > e2) {
		cout << endl;
		cout << a << " < " << b;
	}
	else {
		if (e1 < e2) {
			cout << endl;
			cout << a << " > " << b;
		}
		else {
			cout << endl;
			cout << a << " = " << b;
		}
	}
	*/
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
