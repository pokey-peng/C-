using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class SleepThread
    {
        static void Main()
        {
            Console.Write("Main�߳̿�ʼ��");
            TimeSpan interval = new TimeSpan(0, 0, 1);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("˯��1s��");
                Thread.Sleep(interval);
            }
            Console.Write("Main�߳̽���"); Console.ReadKey();
        }
    }
}
