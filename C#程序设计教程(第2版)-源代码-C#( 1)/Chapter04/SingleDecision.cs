using System;
namespace CSharpBook.Chapter04
{
    class SingleDecision
    {
       static void Main()
        {                            
            int a, b, t;  Random rNum = new Random();
            a = rNum.Next(101); b = rNum.Next(101); //����0~100֮����������a��b
            Console.WriteLine("ԭʼֵ��  a={0}, b={1}", a, b);
            if (a < b) { t = a; a = b; b = t; } //���a<b���򽻻�a��b��ʹ��a����b
           Console.WriteLine("����ֵ��  a={0}, b={1}", a, b); Console.ReadLine();
        }
    }
}
