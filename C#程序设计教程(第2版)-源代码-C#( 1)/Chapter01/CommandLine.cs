// compile��csc CommandLine.cs  -> CommandLine.exe
using System;
namespace CSharpBook.Chapter01
{
    class CommandLine
    {
        	static void Main(string[] args)
        	{ // �����������
             Console.WriteLine("�������� = {0}", args.Length);
	        for (int i = 0; i < args.Length; i++)  // ʹ��for������������ֵ
	        {
	            Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
	        }
	        foreach (string s in args)  // ʹ��foreach������������ֵ
	        {
	            Console.WriteLine(s);
	        }
	    }
    }
}
