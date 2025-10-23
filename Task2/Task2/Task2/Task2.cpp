//Find Sum in an array

#include <iostream>

void FindSumVariables();

int main()
{
    FindSumVariables();
}

void FindSumVariables() {
    int  sum = 0;
    int inputs[5];

    std::cout << "Enter 5 numbers: \n";
    
    for (int i = 0; i < 5; i++) {
        std::cin >> inputs[i];
        sum += inputs[i];
    }
    std::cout << "Sum of the numbers you entered is = " << sum << std::endl;
}
