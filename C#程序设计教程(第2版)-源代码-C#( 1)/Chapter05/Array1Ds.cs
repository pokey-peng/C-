using System;
namespace CSharpBook.Chapter05
{
    class Array1Ds
    {
        public static void DisplayArray(int[] A)  // ��ӡ��������
        { 
            foreach (int i in A) Console.Write("{0,5} ", i);
            Console.WriteLine();
        }
        static void Main()
        {
            int i, sum = 0, MaxA, MinA, MaxI=0, MinI=0, t;
            int[] A = new int[10] ;  Random rNum = new Random();
            for (i = 0; i < A.Length; i++) A[i] = rNum.Next(11); //���鸳ֵ(0~10�����)
            Console.WriteLine("ԭʼ����: ");  DisplayArray(A);
            //�������Ԫ��֮�͡�ƽ��ֵ
            for (i = 0; i < A.Length; i++) sum += A[i];
            Console.WriteLine("�����Ԫ��֮��={0},ƽ��ֵ={1}", sum, sum/A.Length);
            //���������ֵ����Сֵ�Լ�����λ��
            MaxA = A[0];  MinA = A[0];
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] < MinA)
                {
                    MinA = A[i];  MinI = i;
                }
                if (A[i] > MaxA)
                {
                    MaxA = A[i];  MaxI = i;
                }
            }
            Console.WriteLine("�������ֵ = {0}, ��Сֵ = {1}", MaxA, MinA);
            //��Сֵ�������һ��Ԫ�ؽ���
            t = A[0]; A[0] = A[MinI]; A[MinI] = t;
            //���ֵ�����һ��Ԫ�ؽ���
            t = A[A.Length - 1]; A[A.Length - 1] = A[MaxI]; A[MaxI] = t;
            Console.WriteLine("Ԫ�ؽ����������: "); DisplayArray(A); //��ӡ����
        }
    }
}
