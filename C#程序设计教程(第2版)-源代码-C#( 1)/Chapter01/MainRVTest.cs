// compile��csc MainRVTest.cs  -> MainRVTest.exe
using System;
namespace CSharpBook.Chapter01
{
    class HelloWorld
    {
        public static int Main(String[] args) 
        {
	   	   if (args.Length == 0)
	   	   {
	    		   Console.WriteLine("������һ��string��Ϊ������");
	    		   return 1;
		    }else{
	   	   		Console.WriteLine("Hello," + args[0]);
	       		return 0;
	       	}
        }
    }
} 
