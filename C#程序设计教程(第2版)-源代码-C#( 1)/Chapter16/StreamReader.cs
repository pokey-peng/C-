using System; using System.IO;
namespace CSharpBook.Chapter16
{
    class StreamWriterTest
{
        private const string FILE_NAME = @"c:\temp\TestFile.txt";
        public static void Main(String[] args)
        {
           try
           { //����StreamReaderʵ���Դ��ı��ļ��ж�ȡ����.
             using (StreamReader sr = new StreamReader(FILE_NAME))
             {
               String line;
               //��ȡ�ı��ļ�ÿһ�е����ݣ�ֱ���ļ�����
                while ((line = sr.ReadLine()) != null) { Console.WriteLine(line); }
             }
           }
           catch (Exception e) { Console.WriteLine(e.Message); } // �쳣����
           Console.ReadKey();
        }
    }
}
