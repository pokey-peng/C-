// compile��csc AliasNSTest.cs  ->  AliasNSTest.exe
using AliasNS = System;
using AliasClass = System.Console;
namespace CSharpBook.Chapter01
{
    class AliasNSTest
    {
        static void Main()
        {   
            // AliasNS.Console.WriteLine("Hi 1");  // ����
              AliasNS::Console.WriteLine("Hi 2"); // OK
            // AliasClass::WriteLine("Hi 3"); // ����
              AliasClass.WriteLine("Hi 4"); // OK
        }
    }
}
