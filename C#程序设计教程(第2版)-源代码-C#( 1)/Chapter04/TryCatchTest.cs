using System;
public class TryCatchTest
{
    public static void Main()
    {
        int i1 = 1, i2 = 0, i3, i4;
        try
        {
            i3 = i1 / i2;                     //�Զ��׳��쳣DivideByZeroException
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("�������");
        }
        try
        {
            i4 = Int32.Parse("abc");       //�Զ��׳��쳣System.FormatException
        }
        catch (FormatException e)
        {
            Console.WriteLine("��ֵ�ַ�����ʽ����");
            throw e;                     // �����׳��쳣
        }
    }
}
