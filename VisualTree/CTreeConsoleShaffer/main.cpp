#include <cstdlib>
#include <iostream>
#include <string>
int main(int argc, char **argv) 
{
	std::string hello = "Hello, world";
	std::cout << hello << std::endl;
	for(auto c : hello)
	{
		std::cout << c << std::endl;
	}
	std::cin.get();
}