using System;
namespace CSharpBook.Chapter07
{
  class DayCollection
  { // ���ڣ��ַ���������
    string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    private int GetDay(string testDay)//�������ڶ�Ӧ����������������ڣ�����-1
    {
        int i = 0;
        foreach (string day in days)
        {
            if (day == testDay)
            {
                return i;
            }
            i++;
        }
        return -1;
    }
    public int this[string day]     //��������ַ�����������
    {
        get
        {
            return (GetDay(day));
        }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
        DayCollection week = new DayCollection();
        Console.WriteLine("{0}:{1}","Friday",week["Fri"]);
        Console.WriteLine("{0}:{1}","Unknown",week["Unknown"]);  Console.ReadLine();
    }
  }
}
