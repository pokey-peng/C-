using System;
namespace CSharpBook.Chapter02
{  
   class VariableTest
   {  
        static void Main()
        {
            int i1;                                //�������ͱ���
            i1 = 123;                              //��������ֵ
            int i2 = 456;                           //�������ͱ���������ֵ
            double d1 = 12.3, d2 = 45.6, d3;           //����double�ͱ���������������������ֵ
            Console.WriteLine("i1={0}, i2={1}", i1, i2); 
            Console.WriteLine("d1={0}, d2={1}", d1, d2);
            // Console.WriteLine("d3={0}", d3);        //������󣺱���d3������֮ǰû�и�ֵ
            Console.ReadLine();
        }
    }
}
