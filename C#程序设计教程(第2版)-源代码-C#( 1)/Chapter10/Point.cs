using System;
namespace CSharpBook.Chapter10 
{ 
  public struct Point       // ƽ�������
  {
    public int x, y;
    public Point(int x, int y) //��2�������Ĺ��캯��
    {
        this.x = x;  this.y = y;
    }
  }
  class PointTest
  {
    static void Main()
    {
        Point p1 = new Point ();    //����Ĭ�Ϲ��캯��
        Console.WriteLine("ƽ������ 1: x = {0}, y = {1}", p1.x, p1.y);
        Point p2 = new Point(10, 10);  //������2�������Ĺ��캯��
        Console.WriteLine("ƽ������ 2: x = {0}, y = {1}", p2.x, p2.y);
        Point p3; 
        //Console.WriteLine("ƽ������3: x = {0}, y = {1}", p3.x, p3.y);//�������
        p3.x = 22;  p3.y = 33;
        Console.WriteLine("ƽ������ 3: x = {0}, y = {1}", p3.x, p3.y);
        Console.ReadKey();
    }
  }
}
