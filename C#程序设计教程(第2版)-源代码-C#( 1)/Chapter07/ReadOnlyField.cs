using System;
namespace CSharpBook.Chapter07
{
  class ReadOnlyField
  {
    public int x;
    public readonly int y = 2;      //��������ʼ��ֻ���ֶ�
    public readonly int z;         //����ֻ���ֶ�
    public ReadOnlyField()
    {
        z = 3;                //��ʼ��ֻ���ֶ�
    }
    public ReadOnlyField(int p1, int p2, int p3)
    {
        x = p1;  y = p2;  z = p3;
    }
  }
  public class ReadOnlyTest
  {
    static void Main()
    {
        ReadOnlyField p1 = new ReadOnlyField();
        p1.x = 1;                                  // OK
        //p1.z = 33;                                // �������
        Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
        ReadOnlyField p2 = new ReadOnlyField(11, 22, 33);  // OK
        Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z); Console.ReadKey();
    }
  }
}
