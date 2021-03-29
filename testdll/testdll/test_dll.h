#pragma once


extern "C" _declspec(dllexport) int add(int a, int b);

extern "C" _declspec(dllexport) int get_str_len(char* str);

enum my_enum {
	A, B, C
};
extern "C" _declspec(dllexport) int test_enum(my_enum m);

extern "C" _declspec(dllexport) int test_unsigned_long_and_unsigned_long_ptr(unsigned long tmp_ulong, unsigned long* tmp_ulong_ptr);
