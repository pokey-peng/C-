using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class WorkThread1
    {
        static void Main()
        {
            Console.Write("Main�߳̿�ʼ��"); 
            Thread t = new Thread(DoWork); //�����̶߳���ʵ��
            t.Start(); //���������߳�
            for (int i = 0; i < 10; i++) { Console.Write("M"); Thread.Sleep(500); }
            Console.Write(" Main�߳̽�����"); Console.ReadKey();
        }
        public static void DoWork()
        {
            Console.Write("�����߳̿�ʼ��");
            for (int i = 0; i < 10; i++) { Console.Write("W"); Thread.Sleep(500);}
            Console.Write(" �����߳̽�����");
        }
    }
}
