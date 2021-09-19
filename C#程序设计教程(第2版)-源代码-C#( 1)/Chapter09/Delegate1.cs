using System;
namespace CSharpBook.Chapter09
{
    delegate void D(int x);       // ����ί��
    class C
    {
        public static void M1(int i){Console.WriteLine("C.M1:" + i);}
         public static void M2(int i){Console.WriteLine("C.M2:" + i);}
        public void M3(int i){Console.WriteLine("C.M3:" + i);}
    }
    class Test
    {
        static void Main()
        {
            D d1 = new D(C.M1);  //ʹ��new�ؼ��֣�����ί�ж���ָ���ྲ̬����
            d1(-1);              //����M1
            D d2 = C.M2;        //ʹ�ø�ֵ�����������ί�ж���ָ���ྲ̬����
            d2(-2);             //����M2
            C objc = new C();
            D d3 = new D(objc.M3); //ʹ��new�ؼ��֣�����ί�ж���ָ�����ʵ������
            d2(-3);              //����M3
            Console.ReadKey();
        }
    }
}
