// compile��csc /doc:XMLDoc.xml XMLDoc.cs -> XMLDoc.xml�Լ�XMLDoc.exe
using System;
/// <summary>
/// XMLע���ĵ�ʾ����</summary>
/// <remarks>
/// ��ʾ����ʾʹ��XMLע������XMLע���ĵ���
/// �����͹��� </remarks>
public class XMLDoc
{
   /// <summary>
   /// �ڿ���̨��������ʾ��ӭ��Ϣ�� </summary>
   /// <param name="sName">sName���û����ַ�����</param>
   /// <seealso cref="String">
   /// ��μ�String��</seealso>
   public static void SayHello(string sName)
   {
   	   Console.WriteLine(sName + ", Welcome to C# world!");
   }
   /// <summary>
   /// Ӧ�ó������ڵ㡣
   /// </summary>
   /// <param name="args">�û���</param>
   public static int Main(String[] args)
   {
   	   if (args.Length == 0)
   	   {
    		Console.WriteLine("������������������ʽ���£�XMLDoc.exe yourname");
    		return 1;
		}
   	   XMLDoc.SayHello(args[0]);
       return 0;
   }
}
