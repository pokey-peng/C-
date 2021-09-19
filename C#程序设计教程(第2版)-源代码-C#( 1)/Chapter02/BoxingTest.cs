using System;
namespace CSharpBook.Chapter02
{
  class BoxingTest
  {
    static void Main()
    {
            int i = 123;
            object obj1 = i;          //��ʽװ�䣨boxing��
            object obj2 = (object)i;    //��ʽװ�䣨boxing��
            i = 456;                // �ı� i ������
            int j = (int)obj1;          // ���䣨unboxing��
            Console.WriteLine("The value-type value(i) = {0}", i);
            Console.WriteLine("The value-type value(j) = {0}", j);
            Console.WriteLine("The object-type value(obj1) = {0}", obj1);
            Console.WriteLine("The object-type value(obj2) = {0}", obj2);
            Console.ReadKey();
    }
  }
}
