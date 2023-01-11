#include <iostream>
#include <string>

using namespace std;

//void rec(int num) {
//	cout << num << endl;
//	if (num == 0) {
//		return;
//	}
//	rec(--num);
//}

//void rec1(int num) {
//	cout << num << endl;
//
//	rec1(++num);
//}


void Inc(int num) {
	num++;
}

void IncRef(int& num) {
	num++;
}


void CalcPAndS(int a, int b, int& p, int& s) {
	p = (a + b) * 2;
	s = a * b;
}



void IncPtr(int* num) {
	(*num)++;
}


void showLength(const string& str) {
	
	cout << "Len: " << str.size() << endl;
}


int main() {
	{
		//int a = 1;
		//cout << "Start a: " << a << endl;//1
		//Inc(a);
		//cout << "Inc() " << a << endl;//1
		//IncRef(a);
		//cout << "incRef() " << a << endl;//2
		/*int a = 3, b = 5, s, p;
		CalcPAndS(a, b, p, s);

		cout << "P = " << p;
		cout << "\nS = " << s;*/
		//rec1(0);
		//cout << rec1;
		{
			/*int a = 10;
			int b = 11;

			cout << "Value\taddres\n";
			cout << a << "\t" << &a << endl;
			cout << b << "\t" << &b << endl;

			int* pA = &a;

			cout << *pA << "\t" << pA << endl;
			*pA = 101;
			cout << "Update a:\n";
			cout << a << "\t" << &a << endl;


			cout << *(pA+8 )<< "\t" << pA+8 << endl;
			cout << "Update b:\n";

			*(pA + 8) = 12;
			cout << b << "\t" << &b << endl;*/

			//bin	-> 0 1								1011
			//oct	-> 0 1 2 3 4 5 6 7					13
			//dec	-> 0 1 2 3 4 5 6 7 8 9				11
			//hex	-> 0 1 2 3 4 5 6 7 8 9 A B C D E F	B

			//int n = 10;

			//int arr[10]{4,1,6,3,9,10};
			//cout << arr+1 << "\t" << *(arr + 1);
			////arr[3];
			//// *(arr+3);
			//int * darr = new int[n];
			//for (int i = 0; i < n; i++)
			//{
			//	cin >> darr[i];
			//}
			//delete[] darr;
			//"gahsjs";

			/*int& refN = n;
			refN = 100;
			cout << n;*/
		}
	}

	/*int a = 1;
	cout << a << endl;
	IncRef(a);
	IncPtr(&a);
	cout << a << endl;*/

	int a = 10;
	
	string str = "qwertyuiopasdfghjk";
	
	showLength(str);
	cout << str;
	return 0;
}