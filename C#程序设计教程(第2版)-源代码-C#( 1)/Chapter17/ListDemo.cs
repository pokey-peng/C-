using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class ListDemo
    {
        public static void Main()
        {  //����������б�
            List<string> weekdays = new List<string>();
            weekdays.Add("Monday"); weekdays.Add("Wednesday"); weekdays.Add("Thursday");
            weekdays.Add("Friday"); weekdays.Insert(1, "Tuesday");
            foreach (string weekday in weekdays) Console.Write("{0} ", weekday); Console.ReadKey();
        }
    }
}
