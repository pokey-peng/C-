using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class AutoResetEventTest
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);//ͬ���¼�
        static void Main()
        {
            Console.Write("���߳̿�ʼ��");
            Thread t = new Thread(DoWork);
            t.Start();
            waitHandle.WaitOne(); //�ȴ�waitHandle
            Console.Write(" ���߳̽�����"); Console.ReadKey();
        }
        public static void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("."); Thread.Sleep(100);
            }
            waitHandle.Set(); //����waitHandle
        }
    }
}
