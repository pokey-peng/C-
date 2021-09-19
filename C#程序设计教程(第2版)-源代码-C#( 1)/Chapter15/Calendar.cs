using System;
namespace CSharpBook.Chapter15
{
    class CalendarTest
    {
        static void Main(string[] args)
        {
            const string s4 = "    ";          //��4��
            int nYear = DateTime.Today.Year;   //��ǰ�����
            int nMonth = DateTime.Today.Month; //��ǰ���·�
            // ��ӡ���굱�µ�����
            DateTime d1 = new DateTime(nYear, nMonth, 1);
            Console.WriteLine("{0}/{1}", d1.Year, d1.Month);
            Console.WriteLine("SUN MON TUE WED THU FRI SAT");
            int iWeek = (int)d1.DayOfWeek; //��ȡ���굱��1�ŵ�����
            int iLastDay = d1.AddMonths(1).AddDays(-1).Day; //��ȡ���굱�����1�����
            for (int i = 0; i < iWeek; i++) Console.Write(s4);
            for (int i = 1; i <= iLastDay; i++)//��Ӧ���ڣ�Sun,Mon,��,Sat����ӡ��
            {  
                Console.Write(" {0:00} ", i);
                if ((i + iWeek) % 7 == 0) Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
