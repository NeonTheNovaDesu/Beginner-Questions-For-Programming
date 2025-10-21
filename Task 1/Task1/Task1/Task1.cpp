
//Find the maximum value in an array

#include <iostream>

void FindMaxAndMinWithIF();
void FindMaxAndMinWithSwitchCase();

int main()
{
	//FindMaxAndMinWithIF();
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
void FindMaxAndMinWithSwitchCase() {

	int max, min;
	int input[5];
	std::cout << "Enter 5 numbers: " << std::endl;

	for (int i = 0; i < 5; i++) {
		std::cin >> input[i];
	}
	min = input[0];
	max = input[0];
	
	for (int i = 1; i < 5; i++) {
		if (input[i] > max) {
			max = input[i];
		}
		if (min > input[i]) {
			min = input[i];
		}
	}
	std::cout << "Minimum is : " << min << std::endl;
	std::cout << "Maximum is : " << max << std::endl;
}