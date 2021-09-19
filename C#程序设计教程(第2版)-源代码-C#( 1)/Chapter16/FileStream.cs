using System; using System.IO; using System.Text;
namespace CSharpBook.Chapter16
{
    class FileStreamTest
{
       private const string PATH1 = @"Ascii.dat";
       public static void Main(String[] args)
       { //�����ļ�
         using (FileStream fs = File.Create(PATH1))
         {
            AddText(fs, "ASCII���ַ��Ӽ���\r\n");
            for (int i = 32; i < 127; i++)
            {
               AddText(fs, Convert.ToChar(i).ToString());
               if (i % 10 == 0) AddText(fs, "\r\n"); // ÿ��10�ַ�
            }
            // ��ȡ����ʾ������
            fs.Seek(0,SeekOrigin.Begin); //��λ����ʼλ��
            byte[] b = new byte[1024]; UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0) { Console.WriteLine(temp.GetString(b)); }
         }
         Console.ReadKey();
       }
       private static void AddText(FileStream fs, string value)
       {
         byte[] info = new UTF8Encoding(true).GetBytes(value); fs.Write(info, 0, info.Length);
       }
   }
}
