// compile��csc GlobalNSTest.cs  ->  GlobalNSTest.exe 
using System;
namespace CSharpBook.Chapter01
{
    class GlobalNSTest
    {
        // ����һ����Ϊ'System'�����࣬Ϊϵͳ�����鷳.
        public class System { }
        // ����һ����Ϊ'Console'�ĳ�����Ϊϵͳ�����鷳.
        const int Console = 7;
        const int number = 66;
        static void Main()
        {
            // Console.WriteLine(number);  // ��������TestApp.Console
            global::System.Console.WriteLine(number);   //OK��������ȷ�������ռ��е�����
        }
    }
}
