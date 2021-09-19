using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class FindFileByExtension
  {
    static void Main()
    {
        string path = @".\";    //��ǰĿ¼
        //��ȡ��ǰĿ¼�������ļ��б�
        string[] fileNames = System.IO.Directory.GetFiles(path);
        List<System.IO.FileInfo> fileList = new List<System.IO.FileInfo>();
        foreach (string name in fileNames) fileList.Add(new System.IO.FileInfo(name));
        //������ѯ1����ѯ���к�׺Ϊ.cs���ļ�
        IEnumerable<System.IO.FileInfo> fileQuery1 =from file in fileList
                    where file.Extension == ".cs"
                    orderby file.Name
                    select file;
        //ִ�в�ѯ1����ѭ����ʾ��ѯ���
        foreach (System.IO.FileInfo fi in fileQuery1) Console.WriteLine(fi.FullName);
        //������ѯ2����ѯ�����ļ�����������ʱ������ 
        var fileQuery2 = from file in fileQuery1
                     orderby file.CreationTime
                     select new { file.FullName, file.CreationTime };
        var newestFile = fileQuery2.Last();//ִ�в�ѯ��������󴴽����ļ�
        //��ʾ���
        Console.WriteLine("\r\n���µ�.cs�ļ�Ϊ��{0}������ʱ��Ϊ��{1}",newestFile.FullName, newestFile.CreationTime);
        Console.ReadKey();
    }
  }
}
