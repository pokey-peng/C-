using System;
namespace CSharpBook.Chapter10
{
    public class EnumTest
    {   //һ��7��
        enum Days {Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }; 
        enum BoilingPoints {Celcius = 100, Fahrenheit = 212};//�е�����Ϻͻ����¶�
        [FlagsAttribute]
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 }; //4����ɫ
        public static void Main()
        {
            Type weekdays = typeof(Days); Type boiling = typeof(BoilingPoints);
            Console.WriteLine("һ��7�죬��Ӧ��ö������Days�е�ֵ��");
            foreach (string s in Enum.GetNames(weekdays))
              Console.Write("{0}={1} ", s, Enum.Format(weekdays, Enum.Parse(weekdays, s), "d"));
            Console.WriteLine("\nö������BoilingPoints����������ֵ�");
            foreach (string s in Enum.GetNames(boiling))
              Console.Write("{0}={1} ", s, Enum.Format(boiling, Enum.Parse(boiling, s), "d"));
            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine("\nö�ٱ���myColors���������ɫ����ϣ�{0}", myColors);
            Console.ReadLine();
        }
    }
}
