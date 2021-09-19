using System;using System.Threading;
namespace CSharpBook.Chapter14
{
  public class Worker
  {  
    public void DoWork()  //�����߳�ִ���߼���ʵ�ַ���
    {
        Console.Write("�����߳̿�ʼ��");
        while (!_shouldStop)
        {
            Thread.Sleep(50); //�����߳�˯��50����
            Console.Write(".");
        }
        Console.WriteLine("�����߳̽�����");
    }
    public void RequestStop()
    {
        _shouldStop = true;
    }
    private volatile bool _shouldStop; //Volatile�����������ݳ�Ա�������̷߳���
  }
  public class WorkerThreadExample
  {
    static void Main()
    {
        Console.WriteLine("���̣߳����������̡߳�");
        Worker workerObject = new Worker();//���������̶߳��󡣵��������߳�
        Thread workerThread = new Thread(workerObject.DoWork);
        workerThread.Start();//���������߳�
        while (!workerThread.IsAlive) ; //ѭ��ֱ��������߳�
        Thread.Sleep(5000); //�����߳�˯��5000���룬���������߳�����Լ��Ĺ���
        workerObject.RequestStop();//Ҫ�����߳�ֹͣ�Լ�
        workerThread.Join();//ʹ��Join������ֹ��ǰ�̣߳�ֱ�������߳���ֹ
        Console.WriteLine("���߳̽�����");Console.ReadKey();
    }
  }
}
