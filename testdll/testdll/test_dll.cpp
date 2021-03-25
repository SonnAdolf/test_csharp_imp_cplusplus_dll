#include "pch.h"
#include "test_dll.h"

int add(int a, int b)
{
	return a + b;
}

int get_str_len(char* str)
{
	return strlen(str);
}

int test_enum(my_enum m)
{
	return (int)m;
}
