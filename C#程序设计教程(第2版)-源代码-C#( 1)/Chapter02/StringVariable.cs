using System;
namespace CSharpBook.Chapter02
{
  class StringVariable
  {
    static void Main()
    {
       string str1 = "Hello ";  string str2 = "World";
       string str3 = str1 + str2;    // �ַ���ƴ�ӣ��γ�"Hello World "
       char char1 = str3[1];      // ����str3�ĵ�2���ַ�����'e'����index��0��ʼ
       string str4 = "\"C:\\C#\"";  // һ���ַ���������ʹ��ת���
       string str5 = @"""C:\C#"""; //@�ַ�������(���в�������)��������ת�壬��˫������Ҫ����˫����
       Console.WriteLine(str3);   Console.WriteLine(char1);
       Console.WriteLine(str4);   Console.WriteLine(str5);
       Console.ReadKey();
    }
  }
}
