using System;
namespace CSharpBook.Chapter02
{  
    class ConstantTest
    {
        static void Main()
        {
            double amount = 10000;           //��������amount(���)����ֵΪ10000
            const double TAXRATE = 0.17;     //��������TAXRATE(��ֵ˰��)Ϊ17%
            //TAXRATE = 0.05;              //�������
            double tax = amount * TAXRATE;  //������ֵ˰
            Console.WriteLine("���={0}; ˰={1}", amount, tax);  Console.ReadLine();
        }
    }
}
