using System;
namespace CSharpBook.Chapter05
{
    class DeleteData
    {
        static void Main()
        {
            int i, k;
            int[] A = new int[]{23,45,78,98,120,156,185,200};
            Console.WriteLine("ԭʼ��������: ");
            foreach (int item in A) Console.Write("{0,5} ", item);
            Console.Write("\n������Ҫɾ����һ������:   ");
            int x = int.Parse(Console.ReadLine());  //�������ַ���ת��Ϊ��Ч������
            int N = A.Length;         //��ȡ��������A�ĳ���N
            for (k = 0; k < N; k++) 
            {
                if (x == A[k]) break;   //�ҵ����ݲ����λ��k
            }
            if (k == N)
            {
                Console.WriteLine("�������޴������޷�ɾ����"); return;
            }
            //�ӵ�k+1��Ԫ�ؿ�ʼ�����һ��Ԫ��������ǰƽ��һ��λ��
            for (i = k+1; i < N; i++) A[i-1] = A[i];
            Console.WriteLine("ɾ�����ݺ������: ");
            for (i = 0; i < A.Length-1; i++) Console.Write("{0,5} ", A[i]);
            Console.WriteLine();
        }
    }
}
