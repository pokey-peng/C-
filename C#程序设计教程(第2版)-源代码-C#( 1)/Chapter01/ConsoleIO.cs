using System;
namespace CSharpBook.Chapter01
{
    class ConsoleIO
    {
        static void Main(string[] args)
        {
           Console.Clear();                      //����
           Console.Write("����������������");    //��ʾ����
           String s = Console.ReadLine();          //��ȡ1�У��Իس�����
           Console.Beep();                      //��ʾ��
           Console.WriteLine("��ӭ����" + s);     //�����ȡ������
           Console.Read();                      //���س�������
        }
    }
}
