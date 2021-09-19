using System;
using System.Threading;
namespace CSharpBook.Chapter09
{   //����AddDelegateί��
    public delegate int MyDelegate(int op1, int op2, out int result); 
    class AsyncDelegate
    {
        public static int Add(int op1, int op2, out int result)
        {
            Thread.Sleep(5000); //˯��5000ms��ģ��ʵ�ʺ�ʱ����
            return (result = op1 + op2);
        }
        static void Main()
        {
            int result;
            MyDelegate d = new MyDelegate(AsyncDelegate.Add);//����ί��ʵ��
            //����BeginInvoke�������������첽����
            Console.WriteLine("�첽����AsyncDelegate.Add()������ʼ");
            IAsyncResult iar = d.BeginInvoke(123, 456, out result, null, null);
            Console.Write("ִ����������");
            for (int i = 0; i < 10; i++) //ģ������������ÿ��500ms��ӡһ�����
            {
                Thread.Sleep(500); Console.Write(".");
            }
            Console.WriteLine("�ȴ�");
            //ʹ��IAsyncResult.AsyncWaitHandle��ȡWaitHandle��ʹ��WaitOne����ִ��
            //�����ȴ����첽�������ʱ�ᷢ��WaitHandle�źţ���ͨ��WaitOne�ȴ�
            iar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("�첽����AsyncDelegate.Add()��������");
            //ʹ��EndInvoke���������첽���ý��������BeginInvoke�󣬿���ʱ����
            //EndInvoke���������첽����δ��ɣ�EndInvoke��һֱ�������첽�������
            d.EndInvoke(out result, iar);
            Console.WriteLine("�첽����AsyncDelegate.Add()���������{0}", result);
            Console.ReadKey();
        }
    }
}
