using System;  using System.Collections.Generic;
public class ListTest
{
    public static void Main()
    {
        List<int> list1 = new List<int>();//���������б�list2
        list1.Add(3); list1.Add(105);//�������б�list1���Ԫ��3��5
        int sum1 = 0;    //���������б�list1��Ԫ��֮�ͣ�����ֵ0
        foreach (int x in list1) sum1 += x;//���
        Console.WriteLine(sum1);     //������
        List<int> list2 = new List<int>();//���������б�list2
        list2.Add(123);  //�������б�list1�������Ԫ��123
        //list2.Add("abc"); //�������б�list1����ַ���"abc"�������±������
        Console.ReadKey();
    }
}
