using System;
namespace CSharpBook.Chapter02
{
    class IntVariable
    {
        static void Main(string[] args)
        {
            Console.Write("����һ��������");    //��ʾ����
            String str1 = Console.ReadLine();      //��ȡ1�У��Իس�����
            long data1 = long.Parse(str1); Console.WriteLine("{0}��ʮ������Ϊ��{0:X}", data1); 
            Console.ReadKey();
        }
    }
}
