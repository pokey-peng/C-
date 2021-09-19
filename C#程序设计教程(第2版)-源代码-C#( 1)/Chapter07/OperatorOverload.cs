using System;
namespace CSharpBook.Chapter07
{
  public struct Complex       // ����
  {
    public int real;           // ʵ��
    public int imaginary;      // �鲿

    public Complex(int real, int imaginary)  //���캯��
    {
        this.real = real;  this.imaginary = imaginary;
    }
    public static Complex operator +(Complex c1, Complex c2) // ���������(+)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }
    public override string ToString()  //����ToString��������ʾ������ʵ�����鲿
    {
        return (String.Format("{0} + {1}i", real, imaginary));
    }
  }
  class TestComplex
  {
    static void Main()
    {
        Complex num1 = new Complex(2, 3);  Complex num2 = new Complex(3, 4);
        Complex sum = num1 + num2;        //ʹ�����������(+)
        //�������ص�ToString����
        Console.WriteLine("��һ��������   {0}", num1);
        Console.WriteLine("�ڶ���������   {0}", num2);
        Console.WriteLine("��������֮�ͣ� {0}", sum); Console.ReadLine();
    }
  }
}
