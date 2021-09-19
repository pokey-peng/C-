using System;
abstract class Shape  //�������
{ 
    public double x, y;
    public Shape(double x, double y) //��2�������Ĺ��캯��
    {
        this.x = x;  this.y = y;
    }
    public abstract double getArea(); //���󷽷�
}
class Rectangle : Shape //������Rectangle
{
    public Rectangle(double width, double height) : base(width, height) { }
    public override double getArea() { return x * y; } //��д����
}
class Circle : Shape //������Circle
{
    public Circle(double radius) : base(radius, 0.0) { }
    public override double getArea() { return Math.PI * x * x; }//��д����
}
public class PolyMorphByAbstractClass
{
    public static void Main() {
	Shape[] shapes = new Shape[5]; //����5����״��������
	Random rnd = new Random();
	for (int i = 0; i < shapes.Length; i++) {//���������״
		int type = rnd.Next(0,1);     //�����������0��1
		double x = rnd.NextDouble() * 100 + 1;//�����������1<=�����<101
		double y = rnd.NextDouble() * 100 + 1;//�����������1<=�����<101
			switch (type) {
			case 0: shapes[i] = new Rectangle(x,y); break;
			case 1: shapes[i] = new Circle(x); break;
			}
		}
		double area_sum = 0.0; //����״���֮��
		for (int i = 0; i < shapes.Length; i++) { //��ӡ����״
			if (shapes[i] is Rectangle) {
                Console.WriteLine("��{0}����״������({1:0.00}, {2:0.00}),���={3:0.00}",i+1, shapes[i].x, shapes[i].y, shapes[i].getArea());
			}else{
                Console.WriteLine("��{0}����״��Բ��(1:0.00});���={2:0.00}",i+1, shapes[i].x, shapes[i].getArea());
			}
			area_sum = area_sum + shapes[i].getArea(); //���֮��
		}
        Console.WriteLine("���֮�ͣ�{0:0.00}\n", area_sum);
        Console.ReadKey();
	}
}