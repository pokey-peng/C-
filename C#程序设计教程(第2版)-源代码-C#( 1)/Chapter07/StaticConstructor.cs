using System;
namespace CSharpBook.Chapter07
{
  public class Bus
  { // ��̬���캯��
    static Bus()
    {
        Console.WriteLine("���þ�̬���캯��Bus()");
    }
    public static void Drive()
    {
        Console.WriteLine("���þ�̬����Bus.Drive()");
    }
  }
  class TestBus
  {
    static void Main()
    {
        Bus.Drive();
        Console.ReadLine();
    }
  }
}
