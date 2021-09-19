using System;
namespace CSharpBook.Chapter07
{
  class TimePeriod
  {
    private double seconds;
    public double Hours
    {   
        get { return seconds / 3600; }       //��ת��ΪСʱ
        set
        {
            if (value > 0)
                seconds = value * 3600;   //Сʱת��Ϊ��
            else
                Console.WriteLine("Hours��ֵ����Ϊ����");
        }
    }
  }
  class Program
  {
    static void Main()
    {
        TimePeriod t = new TimePeriod();
        t.Hours = -6;         //����set������
        t.Hours = 6;          //����set������
        //����get������
        Console.WriteLine("��СʱΪ��λ��ʱ�䣺 " + t.Hours);
        Console.ReadLine();
    }
  }
}
