using System;
namespace CSharpBook.Chapter07
{
  class CoOrds        // ƽ������
  {
    public int x, y;
    // Ĭ�Ϲ��캯��
    public CoOrds()      //Ĭ�Ϲ��캯��
    {
        x = 0; y = 0;
    }
    // ��2�������Ĺ��캯��:
    public CoOrds(int x, int y) //��2�������Ĺ��캯��
    {
        this.x = x; this.y = y;
    }
    // ��дToString����:
    public override string ToString()
    {
        return (String.Format("({0},{1})", x, y));
    }
  }
  class MainClass
  {
    static void Main()
    {
        CoOrds p1 = new CoOrds();       //����Ĭ�Ϲ��캯��
        CoOrds p2 = new CoOrds(5, 3);    //������2�������Ĺ��캯��
        // ʹ�����ص�ToString������ʾ���
        Console.WriteLine("ƽ������ #1 λ�� {0}", p1);
        Console.WriteLine("ƽ������ #2 λ�� {0}", p2); Console.ReadLine();
    }
  }
}
