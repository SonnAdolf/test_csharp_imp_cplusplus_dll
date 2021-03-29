using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace test_imp_dll
{
    class CPPDLL
    {
        public enum my_enum { A, B, C };
        const String str = @"D:\Files\test\testdll.dll";
        [DllImport(str, EntryPoint = "add", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);

        [DllImport(str, EntryPoint = "get_str_len", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern int get_str_len(byte[] str);

        [DllImport(str, EntryPoint = "test_enum", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static int test_enum(my_enum m);

        [DllImport(str, EntryPoint = "test_unsigned_long_and_unsigned_long_ptr", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static int test_unsigned_long_and_unsigned_long_ptr(System.Int32 tmp_ulong, ref System.Int32 tmp_ulong_ptr);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            int ret;
            ret = CPPDLL.add(1, 2);
            Console.WriteLine("add返回值：" + ret);
            Console.WriteLine("\n");
            string tt = "hahaha";
            byte[] ss = System.Text.Encoding.Default.GetBytes(tt);
            ret = CPPDLL.get_str_len(ss);
            Console.WriteLine("get_str_len返回值：" + ret);
            Console.WriteLine("\n");
            Console.Write("test_enum返回值："+CPPDLL.test_enum(my_enum.C));
            Console.WriteLine("\n");
            Console.WriteLine("C#的System.Int32字节数为（与C++ unsigned long的长度对应）：" + sizeof(System.Int32));
            Console.WriteLine("\n");
            System.Int32 tmp2 = 2;
            test_unsigned_long_and_unsigned_long_ptr(2,ref tmp2);
            Console.WriteLine("test_unsigned_long_and_unsigned_long_ptr返回值："+ tmp2);
            Console.WriteLine("\n");
        }
    }
}



