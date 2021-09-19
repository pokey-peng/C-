using System;
namespace CSharpBook.Chapter09
{
    delegate void D(int[] A);   // ����ί��
    class ArraySort
{   
        public static void DisplayArray(int[] A) //��ӡ����
        {  foreach (int i in A) Console.Write("{0,5} ", i); Console.WriteLine(); }
        public static void GeneralSort(int[] A, D sort) 
        {   //ͨ���������
            sort(A);  // ���������㷨
            Console.WriteLine("��������: ");  DisplayArray(A); //��ʾ����
         }
        public static void BubbleSort(int[] A) 
        {   //ð���㷨
            int i, t;
            int N = A.Length;   //��ȡ����A�ĳ���N
            for (int loop = 1; loop <= N - 1; loop++)//��ѭ������N-1�ֱȽ�
            {   for (i = 0; i <= N - 1 - loop; i++) //��ѭ�������Ƚϣ������³�
                  if (A[i] > A[i + 1])       //������������
                  { t = A[i]; A[i] = A[i + 1]; A[i + 1] = t; }
            }
        }
        public static void SelectSort(int[] A)
        {   //ѡ���㷨
            int i, t, MinI;
            int N = A.Length;  //��ȡ����A�ĳ���N
            for (int loop = 0; loop <= N - 2; loop++)//��ѭ������N-1�ֱȽ�
            {  MinI = loop;
               for (i = loop; i <= N - 1; i++) //��ѭ������������������Сֵ
                   if (A[i] < A[MinI]) MinI = i;
               t = A[loop]; A[loop] = A[MinI]; A[MinI] = t;//��Сֵ���һ��Ԫ�ؽ���
            }
        }
        static void Main()
        {   int[] A = new int[10];  Random rNum = new Random();
            //����A��ֵ(0~100֮��������)
            for (int i = 0; i < A.Length; i++) A[i] = rNum.Next(101);
            Console.WriteLine("ԭʼ����: "); DisplayArray(A);  //��ʾ����
            D d1 = new D(ArraySort.BubbleSort);//����ί��ʵ����ָ��ð���㷨
            Console.Write("ð���㷨---"); GeneralSort(A, d1);
            D d2 = new D(ArraySort.SelectSort); //����ί��ʵ����ָ��ѡ���㷨
            Console.Write("ѡ���㷨---"); GeneralSort(A, d2); Console.ReadKey();
        }
    }
}
