using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class QuerySize
  {
    public static void Main()
    {
        string startFolder = @"c:\C#\Chapter13";
        //��ȡc:\C#\Chapter13Ŀ¼����������Ŀ¼�е�.csԴ�ļ��б�
        IEnumerable<string> fileList = System.IO.Directory.GetFiles(startFolder, "*.cs", System.IO.SearchOption.AllDirectories);
        //������ѯ����ȡ.csԴ�ļ����ļ���С�б�
        var fileQuery = from file in fileList
                     select (new System.IO.FileInfo(file)).Length;
        long[] fileLengths = fileQuery.ToArray();//ִ�в�ѯ������.cs���ļ���С�б�
        long largestFile = fileLengths.Max();//ִ�оۺ����㣬��ȡ����ļ��Ĵ�С
        long totalBytes = fileLengths.Sum();//ִ�оۺ����㣬��ȡ�����ļ���С�ĺ�
        //��ʾ���
        Console.WriteLine("�ļ�����{0}�����ֽ�����{1}", fileList.Count(), totalBytes);
        Console.WriteLine("�����ļ�Ϊ {0} �ֽ�", largestFile);
        Console.ReadKey();
    }
  }
}
