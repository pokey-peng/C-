using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class AbortThread
    {
        public static void Main()
        {
            Console.WriteLine("������ʼ�����������������̡߳�");
            Thread t = new Thread(new ThreadStart(TestMethod));
            t.Start(); Thread.Sleep(1000);
            Console.Write("��������ͼ���ٹ����̡߳�");
            t.Abort("Main"); //����t
            t.Join();//�ȴ��߳���ֹ
            Console.WriteLine("��������ֹ�����߳���ֹ��"); Console.ReadKey();
        }
        static void TestMethod()
        {
            try
            {
                while (true)
                {
                    Console.Write("T"); Thread.Sleep(100);
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine("�̱߳�{0}��ֹ��", (string)abortException.ExceptionState);
            }
        }
    }
}
