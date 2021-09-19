using System;
public class ClassA  // ����ClassA
{                           
    protected double x_protected;  // �ܱ���ʵ���ֶ�
    private double y_private;     // ˽��ʵ���ֶ�
    public void setY(double y)   // ����ʵ������
    {                  
        this.y_private = y;
    }
    public double getY()     // ����ʵ������
    {                       
        return this.y_private;
    }
    public ClassA(double x, double y) // ��2�������Ĺ��캯��
    {                 
        this.y_private = y;
    }
}
public class ClassB : ClassA
{
    public double z_public;     // ����ʵ���ֶ�
    public void print()         // ����ʵ������
    {                       
        Console.WriteLine(this.x_protected); //OK���ɷ��ʻ����protected��Ա
        //Console.WriteLine(this.y_private); //������󣬲���ֱ�ӷ��ʻ����private��Ա
        Console.WriteLine(this.getY());   //OK��ͨ������ķ�����ӷ�����private��Ա
        Console.WriteLine(this.z_public);
    }
    public ClassB(double x, double y, double z)
        : base(x, y)// ��3�������Ĺ��캯�������û���Ĺ��캯��
    {
        this.z_public = z;
    }
}
public class SubClassMemeberTest
{
    static void Main(string[] args)
    {
        ClassB obj = new ClassB(1.0, 2.0, 3.0);
        obj.setY(2.2);                 //����ClassB�ĳ�ԱsetY(double y)������ClassA�̳�
        obj.z_public = 3.3;             //����ClassB�ĳ�Աz_public
        Console.WriteLine(obj.GetType());//����ClassB�ĳ�ԱgetClass()������Object�̳�
        obj.print();                   //����ClassB�ĳ�Աprint()
        Console.ReadKey();
    }
}
