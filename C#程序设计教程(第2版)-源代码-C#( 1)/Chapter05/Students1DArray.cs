using System;
namespace CSharpBook.Chapter05
{
    class Students1DArray
    {
        static void Main()
        {
            int[] mark= new int[100];       //������100������������
            Random rNum = new Random();  //���������
            int i,sumMark=0,avgMark,overAvg=0;
            for (i = 0; i < 100; i++)
            {
                mark[i] = rNum.Next(101); //�������ѧ���ɼ���0~100��
                sumMark += mark[i];     //ͳ�Ƴɼ��ܺ�
            }
            avgMark = sumMark / 100;  //��ƽ���ɼ�
            for (i = 0; i < 100; i++)     //ͳ�Ƹ���ƽ���ɼ���ѧ������
            {
                if (mark[i] > avgMark) overAvg++;
            }
            Console.WriteLine("100��ѧ���ĳɼ���ƽ���ɼ�={0}������ƽ���ɼ���ѧ������={1}", avgMark, overAvg);
        }
    }
}
