// Global Variables:

// Next code line has two issues:
// cpp:S5945  Use "std::string" instead of a C-style char array     - not suppressed
// cpp:S5421  Global variables should be const.                     - not suppressed
char abc[10] = { 'o','1' };

// TODO:                                                            - suppressed


// Next code line has two issues:
// cpp:S5945  Use "std::string" instead of a C-style char array     - not suppressed
// cpp:S5421  Global variables should be const.                     - suppressed
char def[10] = { 'o','1','2','3','4','5','6','7','8','9' };
