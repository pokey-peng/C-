using System;
namespace CSharpBook.Chapter02
{
    public class DynamicDemo
    {
        static void Main()
        {
            for (int i = 0; i < 2; i++)
            {
                dynamic arg = (i == 0) ? (dynamic)10 : "A";
                dynamic result = plus(arg);//��һ��ѭ������int���ͣ��ڶ�����string����
                M(result);//���ݴ���M��ֵ��ʵ�����ͣ�������Ӧ�����ط���
            }
            Console.ReadKey();
        }
        static dynamic plus(dynamic arg) { return arg + arg; }
        static void M(int n) { Console.WriteLine("M(int):{0}", n); }
        static void M(string s) { Console.WriteLine("M(string):{0}", s); }
    }
}
