

#include <iostream>
#include <string>
int main()
{

    std::string arr[3][2][2] = {
    {{"sara"},{"computer","math"}},
    {{"ali"},{"math","law"}},
    {{"reza"},{"computer","law"}}
    };
    
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 2; j++) {
            for (int k = 0; k < 2; k++) {
                std::cout << arr[i][j][k] << " ";
            }
        }
       std::cout << std::endl;
    }
}
