#include "TwoThreeTree.h"

int main(int argc, char **argv) {
	TwoThreeTree ttTree;
	for (size_t i = 0; i < 100; i++)
	{
		ttTree.insert(i);
	}
	ttTree.print();
	std::cin.get();
}