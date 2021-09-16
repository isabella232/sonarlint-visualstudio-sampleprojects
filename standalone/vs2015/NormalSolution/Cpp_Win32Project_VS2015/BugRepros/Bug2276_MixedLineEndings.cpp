// NOTE: do NOT normalize the line endings for this file - needed to repro the bug
// https://github.com/SonarSource/sonarlint-visualstudio/issues/2276

#include <iostream>

int main()
{
	std::cout << "text" << std::endl;
}