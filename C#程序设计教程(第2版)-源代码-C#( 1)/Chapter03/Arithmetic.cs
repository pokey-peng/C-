using System;
namespace CSharpBook.Chapter03
{
    class ArithmeticTest
    {
        static void Main()
        {  // ++ (���������) ,-- (���������)
            double x,y;
            x = 1.5;  y = ++x;
            Console.WriteLine("x={0}, y={1}",x, y);
            x = 1.5;  y = x++;
            Console.WriteLine("x={0}, y={1}", x, y);
            x = 1.5;  y = --x;
            Console.WriteLine("x={0}, y={1}", x, y);
            x = 1.5;  y = x--;
            Console.WriteLine("x={0}, y={1}", x, y);
            x=5.8;  int i = 5;
            Console.WriteLine("i={0}, +i={1}", i, +i);            // һԪ+
            Console.WriteLine("i+5={0}, i+.5={1}", i + 5, i + .5);   // ��Ԫ+
            Console.WriteLine("x={0}, x + \"5\"= {1}", x, x + "5");  //�ַ���ƴ��(double�Զ�ת��Ϊstring)
            Console.WriteLine("'5' + '5'= {0}, 'A' + 'A'= {1}", '5' + '5', 'A' + 'A'); //�ַ�ת��ΪASCII��ֵ������ֵ���
            i= 5;
            Console.WriteLine("i={0}, -i={1}, i-1={2}, i-.5={3}", i, -i, i - 1, i - .5); // - (һԪ- &��Ԫ����)
            Console.WriteLine("i*8={0}, -i*.8={1}", i * 8, -i * .8);  // * (�˷�)
            Console.WriteLine("i/2={0}, -i/2.1={1}", i / 2, -i / 2.1); // (����)
            Console.WriteLine("i%2={0}", i % 2);              // % ( ȡģ)
            Console.ReadKey(); 
        }
    }
}
