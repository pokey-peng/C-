using System;using System.Reflection;
namespace CSharpBook.ChapterAI
{
 class AppDomain1
 {
   public static void Main()
   {
      Console.WriteLine("��Ӧ�ó����� " + AppDomain.CurrentDomain.FriendlyName);
      //����Ӧ�ó�����
      AppDomain newDomain = AppDomain.CreateDomain("NewApplicationDomain");
      Console.WriteLine("��Ӧ�ó����� " + newDomain.FriendlyName);
      //���벢ִ��Ӧ�ó���
      Console.WriteLine("����Ӧ�ó��� " + @"C:\C#\Chapter01\Hello.exe"); 
      newDomain.ExecuteAssembly(@"C:\C#\Chapter01\Hello.exe");
      //ж��Ӧ�ó�����
      AppDomain.Unload(newDomain);
   }
 }
}
