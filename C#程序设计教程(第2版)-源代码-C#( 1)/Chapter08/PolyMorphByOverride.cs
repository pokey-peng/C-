using System;
class A0 // ����
{ 
    public virtual void MethodA()
    {
        Console.WriteLine("����A0�����ʵ������MethodA()");
    }
}
class A01 : A0 // ������
{ 
    public override void MethodA()//��д��������д�ӻ���A0�̳еķ���
    {    
        Console.WriteLine("����A01�����ʵ������MethodA()");
    }
}
class A02 : A0 // ������
{
    public override void MethodA()//��д��������д�ӻ���A0�̳еķ���
    {    
        Console.WriteLine("����A02�����ʵ������MethodA()");
    }
}
public class PolyMorphByOverride1
{
    public static void Main()
    {
        A0 obj0 = new A0(); A0 obj01 = new A01(); A0 obj02 = new A02();
        obj0.MethodA(); //obj0����ʱ����Ϊ����A0���ʵ��û���A0��MethodA����
        obj01.MethodA();//obj01����ʱ����Ϊ����A01���ʵ�����A01��MethodA����
        obj02.MethodA();//obj02����ʱ����Ϊ����A02���ʵ�����A02��MethodA����
        Console.ReadKey();
    }
}
