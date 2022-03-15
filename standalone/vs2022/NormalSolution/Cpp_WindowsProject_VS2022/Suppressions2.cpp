#include "framework.h"

#define MAX_LOADSTRINGX 100                       // cpp:50278 - suppressed

// Global Variables:
HINSTANCE hInstXXX;                               // cpp:S5421 - not suppressed

// Next code line has two issues:

// cpp:S5945  Use "std::string" instead of a C-style char array     - not suppressed
// cpp:S5421  Global variables should be const.						- suppressed
WCHAR szTitleX[MAX_LOADSTRINGX];                  // The title bar text
