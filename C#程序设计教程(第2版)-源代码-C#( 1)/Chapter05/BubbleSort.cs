using System;
namespace CSharpBook.Chapter05
{
    class BubbleSort
    {
        public static void DisplayArray(int[] A)    //��ӡ����
        { 
            foreach (int i in A) Console.Write("{0,5} ", i);
            Console.WriteLine();
        }
        static void Main()
        {
            int i, t;  int[] A = new int[10];  Random rNum = new Random();
            //����A��ֵ(0~100֮��������)
            for (i = 0; i < A.Length; i++) A[i] = rNum.Next(101);
            Console.WriteLine("ԭʼ����: ");  DisplayArray (A);
            int N = A.Length;                     //��ȡ����A�ĳ���N
            for (int loop = 1; loop <= N - 1; loop++)   //��ѭ������N-1�ֱȽ�
            {
                for (i = 0; i <= N - 1 - loop; i++)     //��ѭ�������Ƚϣ������³�
                    if (A[i] > A[i + 1])
                    {
                        t = A[i];  A[i] = A[i + 1];  A[i + 1] = t;
                    }
            }
            Console.WriteLine("��������: ");  DisplayArray (A); // ��ӡ����
        }
    }
}
