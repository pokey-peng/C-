using System;
namespace CSharpBook.Chapter11
{
    class Person { }
    class Student : Person { }
    class MyList<T> { }
    class MySortedList<T> : MyList<T> { }
    class Flock<T> { }
    public class GenericConvert
    {
        public static void Main()
        {
            MyList<String> p1 = new MyList<String>();
            MySortedList<String> c1 = new MySortedList<String>();
            p1 = c1;                   //OK���������ֱ��ת��Ϊ����
            c1 = (MySortedList<String>)p1;//OK���������ֱ��ת��Ϊ����
            MyList<Person> p2 = new MyList<Person>();
            MyList<Student> c2 = new MyList<Student>();
            p2 = c2;               //������󣬲�ͬ���Ͳ����Ķ���֮�䲻��ת��
            c2 = (MyList<Student>)p2;//������󣬲�ͬ���Ͳ����Ķ���֮�䲻��ת��
        }
    }
}
