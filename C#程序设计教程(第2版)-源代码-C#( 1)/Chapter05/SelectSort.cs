using System;
namespace CSharpBook.Chapter05
{
    class SelectSort
    {
        public static void DisplayMatrix(int[] A)
        {
            foreach (int i in A) Console.Write("{0,5} ", i);
            Console.WriteLine();
        }

        static void Main()
        {
            int i, t, MinI;
            int[] A = new int[10];

            Random rNum = new Random();

            for (i = 0; i < A.Length; i++) A[i] = rNum.Next(100); //����A��ֵ(0~100֮��������)

            Console.WriteLine("ԭʼ����: ");
            DisplayMatrix(A);

            int N = A.Length; //��ȡ����A�ĳ���N
            for (int loop = 0; loop <= N - 2; loop++)//��ѭ������N-1�ֱȽ�
            {
                MinI = loop;
                for (i = loop; i <= N - 1; i++)    //��ѭ������������������Сֵ
                    if (A[i] < A[MinI]) MinI = i;
 
                //��Сֵ���������еĵ�һ��Ԫ�ؽ���
                t = A[loop];
                A[loop]=A[MinI];
                A[MinI] = t;
            }

            Console.WriteLine("��������: ");
            DisplayMatrix(A);


            Console.ReadLine();

        }
    }
}