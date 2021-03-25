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
        public static extern int get_str_len(string str);

        [DllImport(str, EntryPoint = "test_enum", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static int test_enum(my_enum m);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            int ret;
            ret = CPPDLL.add(1, 2);
            Console.WriteLine(ret);
            Console.WriteLine("\n");
            ret = CPPDLL.get_str_len("haha");
            Console.WriteLine(ret);
            Console.WriteLine("\n");
            Console.Write(CPPDLL.test_enum(my_enum.C));
            Console.WriteLine("\n");
        }
    }
}



