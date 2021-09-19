using System;
namespace CSharpBook.Chapter15
{
    class MathTriangle//����һ��MathTriangle�࣬˵�������ε��йز���
    {
        private double sideA; private double sideB; private double sideC;//����������
        public MathTriangle(double a, double b, double c)
        { // ����sideA+sideB>sideC and sideA+sideC>sideB and sideB+sideC>sideA
            sideA = Math.Abs(a); sideB = Math.Abs(b); sideC = Math.Abs(c);
        }
        public double GetArea()//�����
        { 
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        public double GetPerimeter()//���ܳ�
        { 
            return sideA + sideB + sideC;
        }
        public double GetAHeight()//��߳�A��Ӧ�ĸ�
        { 
            return 2 * GetArea() / sideA;
        }
        public double GetMaxSide()//����߳�
        {  
            return Math.Max(sideA, Math.Max(sideB, sideC));
        }
        public double GetMinSide()//����̱߳�
        { 
            return Math.Min(sideA, Math.Min(sideB, sideC));
        }
        private double GetPartSideA()//��߳�A��һ����
        { 
            return Math.Sqrt((Math.Pow(sideB, 2.0) - Math.Pow(GetAHeight(), 2.0)));
        }
        static void Main(string[] args)
        {
         MathTriangle aTriangle = new MathTriangle(16.0, 10.0, 8.0);
         Console.WriteLine("�����ε�����Ϊ��16.0��10.0��8.0");
         Console.WriteLine("�߳�A��Ӧ�ĸ�Ϊ��{0:#.00} ", aTriangle.GetAHeight());
         Console.WriteLine("�߳�A��һ���ֳ�Ϊ��{0} ", aTriangle.GetPartSideA());
         Console.WriteLine("�����ε����Ϊ��{0:#.00} ", aTriangle.GetArea());
         Console.WriteLine("�����ε��ܳ�Ϊ��{0} ", aTriangle.GetPerimeter());
         Console.WriteLine("�����ε���ı�Ϊ��{0} ", aTriangle.GetMaxSide());
         Console.WriteLine("�����ε���̵ı�Ϊ��{0} ", aTriangle.GetMinSide());
        }
    } 
}
