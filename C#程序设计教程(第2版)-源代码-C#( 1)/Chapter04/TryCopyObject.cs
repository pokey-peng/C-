using System;
using System.IO;
namespace CSharpBook.Chapter04
{
    class MyExceptionTest
    {
        static void Main(string[] args)
        {
//          Object obj1 = null;  //�������ΪObject obj1 = "abc"�����׳��쳣
Object obj1 = "abc";
          try { InParamTest(obj1); }
          catch (System.ArgumentException e) { System.Console.WriteLine(e.Message); }
          Console.ReadKey();
       }
       static void InParamTest(Object param1)
       {  if (param1 == null) throw new System.ArgumentException("��������Ϊ�գ�", " param1");
          else Console.WriteLine("������ȷ��");
       }
    }
}
