using System; using System.IO;
namespace CSharpBook.Chapter16
{
   class StreamWriterTest
   {
      private const string FILE_NAME = @"c:\temp\TestFile.txt";
      public static void Main(String[] args)
      { //����StreamWriterʵ�������ļ�������ı�
         using (StreamWriter sw = new StreamWriter(FILE_NAME))
         { //���ļ�������ı�
            sw.Write("�ı��ļ�"); sw.WriteLine("��д��/��ȡʾ����");
            sw.WriteLine("----------------------------------");
            sw.WriteLine("д������ {0} �򸡵��� {1}", 1, 4.2);
            bool b = false; char grade = 'A'; string s = "Multiple Data Type!";
            sw.WriteLine("д��Booleanֵ���ַ����ַ��������ڣ�");
            sw.WriteLine(b); sw.WriteLine(grade); sw.WriteLine(s); 
            sw.Write("��ǰ����Ϊ��"); sw.WriteLine(DateTime.Now);
         }
         Console.ReadKey();
      }
   }
}
