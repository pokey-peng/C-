using System;
namespace CSharpBook.Chapter05
{
  class InsertData
  {
    static void Main()
    {
        int i, k;
        int[] A = new int[]{23,45,78,98,120,156,185,200,0};//����0��Ԥ��λ��,��������������
        Console.WriteLine("ԭʼ��������: ");
        for (i = 0; i < A.Length - 1; i++) Console.Write("{0,5} ", A[i]);
        Console.Write("\n������Ҫ���뵽���������е�һ������:   ");
        int x = int.Parse(Console.ReadLine()); //�������ַ���ת��Ϊ��Ч������
        int N = A.Length-1;         //��ȡ��������A�ĳ���N
        for (k = 0; k < N; k++) 
        {
              if (x < A[k]) break;     //�ҵ����ݲ����λ��k
        }
        //�����һ��Ԫ�ؿ�ʼ����ƽ��,Ϊ�������ڳ�λ��
        for (i = N; i > k; i--) A[i] = A[i - 1]; A[k] = x; //����������
        Console.WriteLine("�������ݺ������: ");
        foreach (int item in A) Console.Write("{0,5} ", item); Console.WriteLine();
    }
  }
}
