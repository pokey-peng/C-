using System;
namespace CSharpBook.Chapter03
{
    class StatementTest
    {
        void PrintArea(int r)
        {  //����飺printArea�ķ�����
            const double PI = 3.14;   //������䣺��������
            double a;              //������䣺��������
            if (r > 0)               //�������
            {
                a = PI * r * r;       //��ֵ��䣬����Բ���
                Console.WriteLine("�뾶={0}, ���={1}", r, a);
            }
            else
            {
                Console.WriteLine("�뾶={0}���뾶<=0������", r); //���þ�̬����
            }
        }
        static void Main()
        {  //����飺Main�ķ�����
            StatementTest obj;        //������䣺��������
            obj = new StatementTest(); //��ֵ���/��������
            for (int i = -2; i < 3; i++)  //ѭ�����
            {
                obj.PrintArea(i);    //���ö��󷽷�
            }
            Console.ReadKey();
        }
    }
}
