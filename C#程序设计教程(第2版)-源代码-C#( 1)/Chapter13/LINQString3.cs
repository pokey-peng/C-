using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
class SplitWithGroups
{
    static void Main()
    {   //��ȡ��ǰĿ¼�е�names1.txt
        string[] fileA = System.IO.File.ReadAllLines(@"./names1.txt");
        //��ȡ��ǰĿ¼�е�names2.txt
        string[] fileB = System.IO.File.ReadAllLines(@"./names2.txt"); 
        var mergeQuery = fileA.Union(fileB); //�ϲ��ļ�����
        //������ѯ������һ�����ʣ��գ��ĵ�һ����ĸ����
        var groupQuery = from name in mergeQuery
                         let n = name.Split(',')
                         group name by n[0][0] into g
                         orderby g.Key
                         select g;
        //ִ�в�ѯ��Ϊÿ���鴴��һ�����ļ�����ѭ����ʾ���
        foreach (var g in groupQuery)
        {   //�������ļ�������
            string fileName = @"./testFile_" + g.Key + ".txt";
            //������ݵ�����̨������
            Console.WriteLine(g.Key);
            //д���ļ�
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName))
            {
                foreach (var item in g)
                {
                    sw.WriteLine(item);
                    Console.WriteLine("   {0}", item); //������ݵ�����̨
                }
            }
        }
        Console.ReadKey();
    }
  }
}
