using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class BackgroundThread
    {
        static void Main()
        {
            Console.Write("���߳̿�ʼ��");
            Thread t1 = new Thread(BackgroundThread.NoramlWork);
            t1.Start();
            Thread t2 = new Thread(BackgroundThread.BackgroundWork);
            t2.IsBackground = true; t2.Start();
            Console.WriteLine("���߳̽�����");
        }
        public static void NoramlWork()
        {
            Console.Write("ǰ̨�߳̿�ʼ��");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("N"); Thread.Sleep(100);
            }
            Console.Write("ǰ̨�߳̽�����");
        }
        public static void BackgroundWork()
        {
            Console.Write("��̨�߳̿�ʼ��");
            while (true)
            {
                Console.Write("B"); Thread.Sleep(100);
            }
            Console.Write("��̨�߳̽�����");
        }
    }
}
