using System; using System.Collections;
public class ArrayListTest
{
    public static void Main()
    {
        ArrayList list1 = new ArrayList(); //���������б�list1
        list1.Add(3); list1.Add(105); //�������б�list1���Ԫ��3��5
        int sum1 = 0;    //�����б�list1��Ԫ��֮�ͣ�����ֵ0
        foreach (int x in list1) sum1 += x; //���
        Console.WriteLine(sum1);      //������
        ArrayList list2 = new ArrayList();//���������б�list1
        list2.Add(123); list2.Add("abc"); //�������б�list2���Ԫ��123��"abc"
        int sum2 = 0;                //�����б�list2��Ԫ��֮�ͣ�����ֵ0
        //foreach (int x in list2) sum2 += x;//��ͣ���������ʱ�쳣��InvalidCastException
        Console.WriteLine(sum2);     //������
        Console.ReadKey();
    }
}
