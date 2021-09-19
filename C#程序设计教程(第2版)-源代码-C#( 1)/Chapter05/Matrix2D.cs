using System;
namespace CSharpBook.Chapter05
{
    class Matrix2D
    {
        public static void DisplayMatrix(int[,] A)  // ��ӡ��������
        { 
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++) Console.Write("{0,6} ", A[i, j]);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int i, j, sum = 0, t;
            int[,] A = new int[4, 4];
            for (i = 0; i < 4; i++)        //����A��ֵ
                for (j = 0; j < 4; j++) A[i, j] = i * 4 + j + 1;
            Console.WriteLine("ԭʼ����: "); DisplayMatrix(A);
            Console.WriteLine("�����Ǿ���: ");
            for (i = 0; i < 4; i++)
            {
                for (int k = 0; k < i * 7; k++) Console.Write(" ");     //���ƿո�
                for (j = i; j < 4; j++) Console.Write("{0,6} ", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("�����Ǿ���: ");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < i + 1; j++) Console.Write("{0,6} ", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("�����Խ���֮��: ");
            for (i = 0; i < 4; i++) sum += A[i, i] + A[i, 3 - i];
            Console.WriteLine("{0,6}", sum);
            Console.WriteLine("����Aת��: ");
            for (i = 0; i < 4; i++)
            {
                for (j = i; j < 4; j++)
                {
                    t = A[i, j];  A[i, j] = A[j, i];  A[j, i] = t;
                }
            }
            DisplayMatrix(A);           // ��ӡ����
            Console.ReadLine();
        }
    }
}
