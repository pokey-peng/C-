// compile��csc NamespaceTest.cs  ->  NamespaceTest.exe
using System;
using CSharpBook.Chapter01;
namespace CSharpBook.Chapter01
{
    class SampleClass
    {
        public void SampleMethod()
        {
          Console.WriteLine("SampleMethod inside CSharpBook.Chapter01");
        }
    }
    namespace NestedNamespace   // ����Ƕ�׵������ռ�
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                Console.WriteLine("SampleMethod inside CSharpBook.Chapter01.NestedNamespace");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            // ��ʾ"SampleMethod inside CSharpBook.Chapter01."
            SampleClass outer = new SampleClass();
            outer.SampleMethod();
            //��ʾ"SampleMethod inside CSharpBook.Chapter01."
            CSharpBook.Chapter01.SampleClass outer2 = new CSharpBook.Chapter01.SampleClass();
            outer2.SampleMethod();
            // ��ʾ"SampleMethod inside CSharpBook.Chapter01.NestedNamespace."
            NestedNamespace.SampleClass inner = new NestedNamespace.SampleClass();
            inner.SampleMethod();
            // ��ʾ"SampleMethod inside CSharpBook.Chapter01.NestedNamespace."
            CSharpBook.Chapter01.NestedNamespace.SampleClass inner2 = 
                new CSharpBook.Chapter01.NestedNamespace.SampleClass();
            inner2.SampleMethod();
        }
    }
}
