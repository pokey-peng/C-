using System;using System.Threading;
namespace CSharpBook.Chapter14
{
  public class WorkerThreadExample
  {
    static void Main()
    {
        Console.WriteLine("���̣߳���ʼ����");
        Thread.Sleep(5000); // ���߳�˯��5����
        Console.WriteLine("���̣߳�������"); Console.ReadKey();
    }
  }
}
