using System;
namespace CSharpBook.Chapter01
{
  public class Point             //������Point
  { 
	public int x, y;         //�����ֶ�x��y����ʾ���(x,y)
	public Point(int x, int y)  //���캯��
	{ 
		this.x = x;  this.y = y; 
	}
	public double Distance(Point p) //��������Distance������ö�������㣩�����p����һ����㣩�ľ���
		{ 
			return Math.Sqrt( (x-p.x) *(x-p.x)+ (y-p.y)*(y- p.y));
		}
  }
  class PointTest
  {
      static void Main()
      {
            Point p1 = new Point(0, 0);         //��������p1�������1��
            Point p2 = new Point(10, 20);       //��������p2�������2��
            double dist = p1.Distance(p1);      //���ö���p1�ķ���Distance
            Console.WriteLine("��p1������Ϊ��(" + p1.x + "," + p1.y + ")"); //����p1������x��y
            Console.WriteLine("��p2������Ϊ��(" + p2.x + "," + p2.y + ")"); //����p2������x��y
            Console.WriteLine("����֮��ľ���Ϊ��" + dist);  Console.ReadKey();
        }
  }
}
