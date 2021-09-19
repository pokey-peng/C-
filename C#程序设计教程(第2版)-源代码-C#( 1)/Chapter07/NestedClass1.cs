using System;
namespace CSharpBook.Chapter07
{
class Container
{
    string name = "Container";
    public void sayHello()
    { // �����ڲ���ʵ��ʱ����������ڲ�������thisʵ��
        Nested n = new Nested(this);  n.sayHello();
    }
    public class Nested
    {
        Container c_parent;        // ���ڱ����ⲿ���ʵ��
        public Nested(Container parent) // ���캯��
        {
            c_parent = parent;
        }
        public void sayHello()
        {
            Console.WriteLine(c_parent.name);
        }
    }
}
class Test
{
    static void Main()
    {
      Container c = new Container (); c.sayHello(); Console.ReadKey();
    }
}
}
