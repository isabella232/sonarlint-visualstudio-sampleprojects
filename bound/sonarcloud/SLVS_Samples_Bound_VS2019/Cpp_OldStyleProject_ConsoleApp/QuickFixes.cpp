#include <iostream>
using namespace std;

class BaseException { };
class DerivedException : public BaseException { };
class DerivedException2 : public BaseException { };

/*
* Expected Fixes
* * Replace by a type-alias syntax
*/
typedef int x1; 
int main()
{
	/*
	* Expected Fixes
	* * Change to pointer-to-const,
	* * Replace by nullptr
	*/
	int* a = NULL;
	cout << "Hello CMake." << endl;
	//int a;
// todo 123

	try
	{
		// ...
	}
	/*
	* Expected Fixes
	* * Change to reference-to-const,
	*/
	catch (BaseException& b) // Will catch DerivedException as well
	{
		// ...
	}
	/*
	* Expected Fixes
	* * Swap "DerivedException" and "BaseException" handlers
	* * Remove the dead handler
	* * Change to reference-to-const,
	*/
	catch (DerivedException& d) // Noncompliant, the previous handled effectively hides this one
	{
		// Any code here will be unreachable,
	}
	/*
	* Expected Fixes
	* * Move "BaseException" handler after the more spesific "DerivedException2"
	* * Move "DerivedException2" handler after the more generic "BaseException"
	* * Remove the dead handler
	* * Change to reference-to-const,
	*/
	catch (DerivedException2& d) // Noncompliant, the previous handled effectively hides this one
	{
		// Any code here will be unreachable,
	}

	return 0;
}