using System; using System.IO;
namespace CSharpBook.Chapter16
{
    class BinaryWriterTest
{
       private const string PATH1 = @"Test.dat";
       public static void Main(String[] args)
       {
          using (BinaryWriter bw = new BinaryWriter(File.Open(PATH1, FileMode.Create)))
          {  //�ֱ�д�����������������ַ����Ͳ���������
             bw.Write(10); bw.Write(1.23); bw.Write("ABC"); bw.Write(true);
          }
          Console.ReadKey();
       }
    }
}
