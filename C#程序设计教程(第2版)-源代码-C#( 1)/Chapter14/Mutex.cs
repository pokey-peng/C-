using System;using System.Threading;
namespace CSharpBook.Chapter14
{
  public class Test
  {
    public static void Main()
    {   //��������mutex��ֻ�ܴ���һ����ΪMyMutex��ϵͳ����
         Mutex m = new Mutex(false, "MyMutex");
        //��ͼ��ȡ������mutex�Ŀ���Ȩ��������mutex����һ�߳������ƣ���ȴ�ֱ���䱻�ͷ�
        Console.WriteLine("�ȴ�MyMutex. . . . . ."); m.WaitOne();
        //���ֶ�mutex�Ŀ��ƣ�ֱ���û���ENTER��
        Console.WriteLine("��Ӧ��ӵ��MyMutex���밴������ͷ�֮���˳���");
        Console.ReadKey(); m.ReleaseMutex();
    }
  }
}
