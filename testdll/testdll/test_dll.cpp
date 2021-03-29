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

int test_unsigned_long_and_unsigned_long_ptr(unsigned long tmp_ulong, unsigned long* tmp_ulong_ptr)
{
	if (tmp_ulong == 1)
		*tmp_ulong_ptr = 1;
	else
		*tmp_ulong_ptr = 2;
	return 0;
}