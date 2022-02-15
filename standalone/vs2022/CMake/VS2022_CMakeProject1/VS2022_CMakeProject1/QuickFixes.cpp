#include <iostream>
using namespace std;

class BaseException { };
class DerivedException : public BaseException { };
class DerivedException2 : public BaseException { };

typedef int x1;
int main()
{

	int* a = NULL;
	cout << "Hello CMake." << endl;
	//int a;
// todo 123

	try
	{
		// ...
	}
	catch (BaseException& b) // Will catch DerivedException as well
	{
		// ...
	}
	catch (DerivedException& d) // Noncompliant, the previous handled effectively hides this one
	{
		// Any code here will be unreachable,
	}
	catch (DerivedException2& d) // Noncompliant, the previous handled effectively hides this one
	{
		// Any code here will be unreachable,
	}

	return 0;
}