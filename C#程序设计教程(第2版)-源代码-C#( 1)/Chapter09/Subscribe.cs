using System;
namespace CSharpBook.Chapter09
{
    public class Subscriber
    {
        public static void Method1(object sender, EventArgs e)
        {
            Console.WriteLine("To Do Something...");
        }
        public static void Method2(object sender, EventArgs e)
        {
            Console.WriteLine("To Do Something...");
        }
        public static void Main()
        {  //����ί��ʵ��
            SampleEventHandler d1 = new SampleEventHandler(Subscriber.Method1);
            Publisher p = new Publisher(); //�����¼�
            p.SampleEvent += d1;
            p.SampleEvent += new SampleEventHandler(Subscriber.Method2);//�����¼�
            p.SampleEvent -= d1;       //ȡ���¼�
        }
    }
}
