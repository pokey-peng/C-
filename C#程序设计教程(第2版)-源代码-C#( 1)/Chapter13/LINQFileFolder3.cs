using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
    class QuerySize
    {
        public static void Main()
        {
            string path = @"c:\C#\Chapter13";
            //��ȡc:\C#\Chapter13Ŀ¼�����е��ļ��б�
            IEnumerable<string> fileNames = System.IO.Directory.GetFiles(path, "*.cs");
            List<System.IO.FileInfo> fileList = new List<System.IO.FileInfo>();
            foreach (string name in fileNames) fileList.Add(new System.IO.FileInfo(name));
            string searchTerm = @"foreach";
            //������ѯ����ȡ.csԴ�ļ����ļ���С�б�
            var queryMatchingFiles = from file in fileList
                         let fileText = GetFileText(file.FullName)
                         where fileText.Contains(searchTerm)
                         select file.FullName;
            //ִ�в�ѯ����ѭ����ʾ���
            foreach (string filename in queryMatchingFiles) Console.WriteLine(filename);
            Console.ReadKey();
        }
        static string GetFileText(string name) //��ȡ�ļ��б�
        {
            string fileContents = String.Empty;
            if (System.IO.File.Exists(name)) fileContents = System.IO.File.ReadAllText(name);
            return fileContents;
        }
    }
}
