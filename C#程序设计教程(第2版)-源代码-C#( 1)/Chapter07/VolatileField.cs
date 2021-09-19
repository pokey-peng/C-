using System;
using System.Threading;
namespace CSharpBook.Chapter07
{
  class Test
  {
    public static int result; public static volatile bool finished;
    static void Thread2()
    {
        result = 143;  finished = true;
    }
    static void Main()
    {
        finished = false; 
        new Thread(new ThreadStart(Thread2)).Start();//�����߳�������Thread2()
        //�ȴ�Thread2��ִ�У�result��ֵ������finished����Ϊtrue 
        for (; ; )
        {
            if (finished)
            {
                Console.WriteLine("result = {0}", result); Console.ReadLine();
            }
        }
    }
  }
}
