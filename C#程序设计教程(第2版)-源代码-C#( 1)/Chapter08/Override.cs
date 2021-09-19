using System;
namespace CSharpBook.Chapter08
{
    public class Dimension             //����
    {
        protected double x, y;
        public Dimension() { }  // Ĭ�Ϲ��캯��
        public Dimension(double x, double y) //�����������Ĺ��캯��
        {
            this.x = x; this.y = y;
        }
        public virtual double Area()
        {
            return x * y;
        }
    }
    public class Circle : Dimension   //�����ࣺԲ
    {
        public Circle(double r) : base(r, 0) { }
        public override double Area()  //Բ�����
        {
            return Math.PI * x * x;
        }
    }
    class Sphere : Dimension   //�����ࣺ����
    {
        public Sphere(double r) : base(r, 0) { }
        public override double Area()  //��������
        {
            return 4 * Math.PI * x * x;
        }
    }
    class Cylinder : Dimension    //�����ࣺԲ����
    {
        public Cylinder(double r, double h) : base(r, h) { }
        public override double Area()  //Բ��������
        {
            return 2 * Math.PI * x * x + 2 * Math.PI * x * y;
        }
    }
    class DimensionTest
    {
        static void Main()
        {
            double r = 3.0, h = 5.0;
            Dimension[] dimensions = { new Circle(r), new Sphere(r), new Cylinder(r, h) };
            foreach (Dimension item in dimensions)  // ��ʾ���ֲ�ͬ��״�ģ������
            {
                Console.WriteLine("Area of {0} = {1:F2}", item.GetType(), item.Area());
            }
            Console.ReadKey();
        }
    }
}
