using System;
namespace CSharpBook.Chapter09
{
   delegate void Printer(string s); //����ί��
   class TestClass
   {  
      static void Main()
      {  // ʹ����������ʵ����delegate��
         Printer p = delegate(string j) { Console.WriteLine(j); };
         p("ʹ������������ί�еĵ��á�"); //����delegate���ý��
      }
  }
}
