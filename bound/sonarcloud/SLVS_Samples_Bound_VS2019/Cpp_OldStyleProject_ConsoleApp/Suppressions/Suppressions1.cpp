#include <iostream>

// TODO 1 : suppressed

using namespace std;

int DoStuff()
{
	// 3 issues on the next line of code:
	// cpp:S5350  Make the type of this variable a pointer-to-const.
	// cpp:S4962  Use the "nullptr" literal.	
	// cpp:S1481  unused variable 'a'	Cpp_WindowsProject_VS2022
	// The first two are suppressed. Only SS1481 should be shown
	int* a = NULL;
	
	
	// TODO 2 : not suppressed

	return 1;
}

