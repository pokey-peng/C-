using System;using System.Threading;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class TaskDemo
    {
        public static void Main()
        {
            Task taskA = new Task(() =>{Console.WriteLine("taskA��ʼ��");
                                   Thread.Sleep(5000);//ģ�⹤������
                                   });
            taskA.Start();
            taskA.ContinueWith((t) =>{ Console.WriteLine("������ɣ����ʱ���״̬Ϊ��");
            Console.WriteLine("IsCanceled={0};IsCompleted={1};IsFaulted={2}", t.IsCanceled, t.IsCompleted, t.IsFaulted); });
            Console.ReadKey();
        }
    }
}
