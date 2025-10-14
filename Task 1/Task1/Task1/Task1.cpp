
//Find the maximum value in an array

#include <iostream>

void FindMaxAndMinWithIF();
int main()
{
	FindMaxAndMinWithIF();
}
void FindMaxAndMinWithIF() {
	int num1, num2, num3, num4, max, min;

	std::cin >> num1 >> num2 >> num3 >> num4;

	max = num1;
	min = num1;

	if (max < num2) {
		max = num2;
	}
	else {
		min = num2;
	}
	if (max < num3) {
		max = num3;
	}
	if (min > num3) {
		min = num3;
	}
	if (max < num4) {
		max = num4;
	}
	if (min > num4) {
		min = num4;
	}
	std::cout << "max = " << max << "\n";
	std::cout << "min = " << min;
}