using System;
namespace CSharpBook.Chapter02
{
    class FloatVariable
    {
        static void Main(string[] args)
        {
            //float x0 = 3.5;       // �������:������ʽ�ؽ�double����ת��Ϊfloat����
            float x1 = 3.5F;       // ʹ�ú�׺f��F��ʼ��float�����ͱ���
            double x2 = 3.0;      // ˫���ȸ����ͱ���
            double x3 = 30D;     // ʹ�ú�׺d��D��ʼ��double�����ͱ���
            double x4 = 3.0E+2;   // ˫���ȸ����ͱ�������ѧ��������
            Console.WriteLine("x1={0:0.00}; x2={1:0.00}; x3={2:0.00}; x4={3:0.00}", x1, x2, x3, x4);
            Console.ReadKey();
        }
    }
}
