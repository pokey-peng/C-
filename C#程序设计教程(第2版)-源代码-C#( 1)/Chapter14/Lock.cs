using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    class Account             //�˻���
    {
        private Object thisLock = new Object();
        int balance;
        public Account(int initial)//�˻����캯��
        {
            balance = initial;
        }
        public void Withdraw(object amount)//���˻���ȡ��
        {
            lock (thisLock)//ע�͵������lock��䣬����lock�ؼ��ֵ�Ч��
            {
                if (balance >= (int)amount)   //�˻����>ȡ���
                {
                    Thread.Sleep(500);
                    balance = balance - (int)amount;
                    Console.WriteLine("{0}�����ɹ������={1}", Thread.CurrentThread.Name, balance);
                }else{
                    Console.WriteLine("{0}����ʧ�ܡ��˻����㡣���={1}", Thread.CurrentThread.Name, balance);
                }
            }
        }
    }
    class Test
    {
        static void Main()
        {
            Account acc = new Account(1000); //�½��˻��������Ϊ1000
            Thread t1 = new Thread(acc.Withdraw); t1.Name = "С��";
            Thread t2 = new Thread(acc.Withdraw); t2.Name = "С��";
            t1.Start(600); t2.Start(600); Console.ReadKey();
        }
    }
}
