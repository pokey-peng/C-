using System;
namespace CSharpBook.Chapter07
{
  public class Counter
  {
    private Counter() { }   //˽�й��캯������ֹ��ʵ����
    public static int currentCount;
    public static int IncrementCount()
    {
        return ++currentCount;
    }
  }
  class TestCounter
  {
    static void Main()
    {
        // Counter aCounter = new Counter();   //�������
        Counter.currentCount = 100;
        Console.WriteLine("count��ֵΪ��{0}", Counter.currentCount);
        Counter.IncrementCount();
        Console.WriteLine("count��ֵΪ��{0}", Counter.currentCount); Console.ReadLine();
    }
  }
}
