using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class InterruptThread
    {
        static void Main()
        {
            Console.Write("���߳̿�ʼ��");
            Thread t = new Thread(InterruptThread.DoWork);
            t.Start();
            Console.WriteLine("����100��֮�ڰ�������ж��߳�!");
            Console.ReadKey();
            t.Interrupt();
            t.Join(); //ʹ��Join������ֹ��ǰ�̣߳�ֱ�������߳���ֹ
            Console.WriteLine("���߳̽�����"); Console.ReadKey();
        }
        public static void DoWork(object data)
        {
            Console.Write("�����߳̿�ʼ��");
            try {
                Console.Write("�����߳�׼��˯��100��...");
                Thread.Sleep(100000); //�ӳ�100��
            } catch (ThreadInterruptedException e) {
                Console.WriteLine("˯���ж�!");
            }
        }
    }
}
