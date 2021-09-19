using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class ArrayListDemo
    {
        public static void Main()
        {  //����������ArrayList
            ArrayList list = new ArrayList();
            string str;
            try
            {
                Console.WriteLine("������ɼ������н���");
                while ((str = Console.ReadLine()).Length > 0)
                    list.Add(Int32.Parse(str));
                int sum = 0, max = 0, min = 100;
                foreach (int score in list) //ѭ����ͳ�ƽ��
                {
                    sum += score;
                    if (max < score) max = score;
                    if (min > score) min = score;
                    Console.Write("{0} ", score);
                }
                Console.WriteLine("\nƽ���ɼ���{0}����߷֣�{1}����ͷ֣�{2}", sum / list.Count, max, min);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
