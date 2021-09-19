using System;
public class Person //��ͬ�ڣ�class Person : Object
{ 
    public String name;  public int age;
    public Person(String name, int age) //���๹�캯��
    { 
        this.name = name;  this.age = age;
    }
    public void print()  //�����ʵ������
    {             
        Console.Write("name={0},age={1}", this.name, this.age);
    }
}
public class Student : Person //������
{          
    public String studentID;
    public Student(String name, int age, String id)
        : base(name, age) //�����๹�캯����ʹ��base���û��๹�캯��
    { 
        this.studentID = id;
    }
    public new void print()
    {
        base.print();          //ʹ��base���û���ķ���
        Console.WriteLine(",studentID={0}", this.studentID);
    }
}
public class BaseDemo
{
    static void Main(string[] args)
    {
        Student objstudent = new Student("����", 25, "2014101001");
        objstudent.print(); Console.ReadKey();
    }
}
