//ExtensionMethodTest.cs
//compile��csc /r:ExtensionMethod.dll ExtensionMethodTest.cs -> ExtensionMethodTest.exe
using System; using ExtensionMethods;
namespace CSharpBook.Chapter13
{
    class ExtensionMethodTest
    {
        public static void Main()
        {
            string s = "Hello, Extension Methods. Testing...";
            int i = s.WordCount();
            Console.WriteLine("�ַ�����{0}������{1}������", s, i);
            Console.ReadKey();
        }
    }
}
