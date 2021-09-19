using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class SumColumns
  {
    static void Main(string[] args)
    {   // csv�ļ���ʽ
        // Student ID    Exam#1  Exam#2  Exam#3  Exam#4
        // 2014111,      97,      92,      81,      60
        string[] lines = System.IO.File.ReadAllLines(@"./scores.csv");
        // ������ѯ
        IEnumerable<IEnumerable<int>> query =
            from line in lines
            let x = line.Split(',')      //ת��Ϊ����
            let y = x.Skip(1)        //������1��ѧ��
            select (from str in y
                  select Convert.ToInt32(str));
        var results = query.ToList();//ִ�в�ѯ�����棬����߳�������
        int columnCount = results[0].Count();// ����
        for (int column = 0; column < columnCount; column++)
        {// ������ѯ����ѯ���У���ִ�оۺ�����
            var res2 = from row in results
                    select row.ElementAt(column);
            double average = res2.Average();
            int max = res2.Max(); int min = res2.Min();
            // ��ʾÿ�ο��ԵĽ����ƽ���֡���߷֡���ͷ�
            Console.WriteLine("Exam #{0} ƽ���֣�{1:##.##} ��߷֣�{2} ��ͷ֣�{3}", column + 1, average, max, min);
        }
        Console.ReadKey();
    }
  }
}
