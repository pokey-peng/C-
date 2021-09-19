using System;using System.Threading;
namespace CSharpBook.Chapter09
{   //����ί��
    public delegate int MyDelegate(int op1, int op2, out int result); 
    class AsyncDelegate
    {
        public static int Add(int op1, int op2, out int result)
        {
            Thread.Sleep(5000); //˯��5000ms��ģ��ʵ�ʵĺ�ʱ����
            return (result = op1 + op2);
        }
        static void Main()
        {
            int result;
            MyDelegate d = new MyDelegate(AsyncDelegate.Add); //����MyDelegate����ί��ʵ��
            //����BeginInvoke�������������첽����
            Console.WriteLine("�첽����AsyncDelegate.Add()������ʼ");
            IAsyncResult iar = d.BeginInvoke(123, 456, out result, null, null);
            //ִ����������
            Console.Write("ִ����������");
            for (int i = 0; i < 10; i++) //ģ������������ÿ��500ms�д�ӡһ�����
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("�ȴ�");
            //ʹ��AsyncWaitHandle��ȡWaitHandle��ʹ����WaitOne������ִ��һֱ����
            //�ȴ����첽�������ʱ�ᷢ��WaitHandle�źţ�����ͨ��WaitOne���ȴ���
            iar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("�첽����AsyncDelegate.Add()��������");
            //����BeginInvoke�����ʱ����EndInvoke����������첽����
            //δ��ɣ�EndInvoke��һֱ�������첽�������
            d.EndInvoke(out result, iar); //ʹ��EndInvoke�������ڼ����첽���ý��
            Console.WriteLine("�첽����AsyncDelegate.Add()���������{0}", result);
            Console.ReadKey();
        }
    }
}
