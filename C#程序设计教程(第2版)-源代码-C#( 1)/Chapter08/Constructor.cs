using System;
class SuperClass1 //����1���������Զ�����Ĭ�Ϲ��캯��
{
    public String name, sex;
}
class SubClass11 : SuperClass1 // ������11���������Զ�����Ĭ�Ϲ��캯��
{
    public int age;
}
class SubClass12 : SuperClass1 // ������12
{ 
    public int age;
    public SubClass12() //Ĭ�Ϲ��캯��, �Զ����û���Ĭ�Ϲ��캯��
    {
        Console.WriteLine("���ù��캯��SubClass12()...");
    }
}
class SubClass13 : SuperClass1 // ������13
{ 
    public int age;
    public SubClass13(int age)// ������13�Ĺ��캯����
    {
        Console.WriteLine("���ù��캯��SubClass13()...");
    }
}
class SuperClass2// ����2�������2�������Ĺ��캯������Ĭ�Ϲ��캯��
{
    public String name;  public String sex;
    public SuperClass2(String name, String sex) // ����2�Ĺ��캯��
    {
        this.name = name;  this.sex = sex;
        Console.WriteLine("���ù��캯��SuperClass2()...");
    }
}
class SubClass21 : SuperClass2 // ������21���������SuperClass2��Ĭ�Ϲ��캯��
{
    public int age;
}
class SubClass22 : SuperClass2 // ������22���������SuperClass2��Ĭ�Ϲ��캯��
{ 
    public int age;
    public SubClass22()//Ĭ�Ϲ��캯�����Զ����û���Ĭ�Ϲ��캯����������Ĭ�Ϲ��캯�����ᵼ�±������
    {
        Console.WriteLine("���ù��캯��SubClass22()...");
    }
}
class SubClass23 : SuperClass2
{ // ������23
    public int age;
    public SubClass23(String name, String sex, int age)
        : base(name, sex) // ��Ҫ��ʾ���û��๹�캯����ע�ʹ���佫���±������
    {
        this.age = age;
        Console.WriteLine("����SubClass23�Ĺ��캯��SubClass23()...");
    }
}
public class ConstructorDemo
{
    public static void main(String[] args)
    {
        SubClass11 obj11 = new SubClass11();  //����Ĭ�Ϲ��캯��SubClass11()
        SubClass12 obj12 = new SubClass12();  //����Ĭ�Ϲ��캯��SubClass12()
        //SubClass13 obj13_1 = new SubClass13();//�������SubClass13��Ĭ�Ϲ��캯��
        SubClass13 obj13_2 = new SubClass13(19);//���ù��캯��SubClass13(int age)
        SubClass21 obj21 = new SubClass21();  //���ù��캯��SubClass21()
        SubClass22 obj22 = new SubClass22();  //���ù��캯��SubClass22()
        //���ù��캯��SubClass23(String name, String sex, int age)
        SubClass23 obj23 = new SubClass23("Jack", "M", 19);
    }
}
