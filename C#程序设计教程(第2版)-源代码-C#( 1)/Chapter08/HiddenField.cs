using System;
class Parent            // ����Parent
{
    public String name;
    public String sex;
}
class Child : Parent      // ������Child
{
    public String name;  // ��Ա���������شӻ���̳е�ͬ����Ա����name
    public Child(String name, String sex) // ���캯��
    {
        this.name = name;            //this.name����Child�����ĳ�Ա����
        this.sex = sex;               //this.sex���ô�Parent�̳еĳ�Ա����
        base.name = name + "'s parent"; //base.name���ôӻ���Parent�̳е�ͬ����Ա����name
    }
    public void print()
    {
        Console.WriteLine(this.name + " " + this.sex + " " + base.name);
    }
}
public class HiddenFieldDemo
{
    static void Main(string[] args)
    {
        Child obj1 = new Child("Mary", "F");
        obj1.print();  Console.ReadKey();
    }
}
