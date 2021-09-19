using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class PriorityThread
    {
        static void Main()
        {
            Thread tLowest = new Thread(PriorityThread.DoWork1); //�����̶߳���ʵ��
            Thread tHighest = new Thread(PriorityThread.DoWork2); //�����̶߳���ʵ��
            tLowest.Priority = ThreadPriority.Lowest; //�����̵߳����ȼ�
            tHighest.Priority = ThreadPriority.Highest; //�����̵߳����ȼ�
            tLowest.Start("Lowest"); //�����߳�
            tHighest.Start("Highest"); //�����߳�
            Console.WriteLine("�����ĵȴ�5��......"); Thread.Sleep(5000);
            tLowest.Abort(); tHighest.Abort(); Console.ReadKey();
        }
        public static void DoWork1(object data)
        {
            long count1 = 0;
            try{
                while (true) { count1++;}
            }catch (ThreadAbortException e){
                Console.WriteLine("{0} , count1={1}", data, count1);
            }
        }
        public static void DoWork2(object data)
        {
            long count2 = 0;
            try{
                while (true) { count2++; }
            }catch (ThreadAbortException e){
                Console.WriteLine("{0}, count2={1}", data, count2);
            }
        }
    }
}
