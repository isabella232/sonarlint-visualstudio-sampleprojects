# CMakeList.txt : Top-level CMake project file, do global configuration
# and include sub-projects here.
#
cmake_minimum_required (VERSION 3.8)
set(CMAKE_EXPORT_COMPILE_COMMANDS ON)

project ("VS2019_CMakeProject1")

# Include sub-projects.
add_subdirectory ("VS2019_CMakeProject1")
