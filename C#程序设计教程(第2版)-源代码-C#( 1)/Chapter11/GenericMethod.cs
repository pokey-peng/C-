using System;
namespace CSharpBook.Chapter11
{
  public class GenericMethod
  { 
    static void Swap<T>(ref T lhs, ref T rhs) //�������ͷ��������߽���
    {
        T temp; temp = lhs; lhs = rhs; rhs = temp;
    }
    public static void Main()
    {
        int a = 1; int b = 2;
        Console.WriteLine("Original value, a = {0} , b = {1}", a, b);
        Swap<int>(ref a, ref b); //���÷��ͷ�����ָ�����Ͳ���������
        Console.WriteLine("After swapping, a = {0} , b = {1}", a, b);
        double c = 1.1d; double d = 2.2d;
        Console.WriteLine("Original value, c = {0} , d = {1}", c, d);
        Swap(ref c, ref d); //���÷��ͷ�����ʡ�����Ͳ��������������ƶϳ��ò���
        Console.WriteLine("After swapping, c = {0} , d = {1}", c, d); Console.ReadLine();
    }
  }
}
