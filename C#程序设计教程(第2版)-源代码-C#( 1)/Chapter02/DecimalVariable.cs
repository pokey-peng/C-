using System;
namespace CSharpBook.Chapter02
{
  class DecimalVariable
  {
     static void Main()
     {
        // decimal x0=99.99;      // ������󣺲�����ʽ�ؽ�double����ת��Ϊdecimal����
        decimal x1 = 99.99m;    // ʹ�ú�׺m��M��ʼ��decimal���ͱ���
        decimal x2 = 9999999999999999999999999999m;
        Console.WriteLine("{0:C}", x1);
        Console.WriteLine("{0:C}",x2);
        Console.ReadKey();
      }
  }
}
