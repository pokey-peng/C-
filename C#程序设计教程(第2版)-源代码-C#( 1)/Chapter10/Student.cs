using System;
namespace CSharpBook.Chapter10 
{
  struct Student    //Student�ṹ
  {
    public struct Grade    //Ƕ�׽ṹ��������
    {
        public string courseName; public float courseGrade;//�γ����ơ�����
        public Grade(string name, float grade)  //Ƕ�׽ṹ�Ĺ��캯��
        {
            courseName = name;  courseGrade = grade;
        }
    }
    public string studentID, studentName;  //ѧ��ѧ�š�����
    public Grade[] grades;              //������Ƕ�׽ṹ���ͣ�
    public Student(string id, string name)  //ѧ���ṹ�Ĺ��캯��
    {
        studentID = id; studentName = name; grades = new Grade[3];
    }
  }
  class TestClass
  {
    static void Main()
    {
        Student s1 = new Student("200910101", "zhangsan");
        s1.grades = new Student.Grade[] { new Student.Grade("����", 80),
             new Student.Grade("��ѧ", 90), new Student.Grade("Ӣ��", 100) };
        Console.WriteLine("Student ID={0}, Student Name={1}",s1.studentID,s1.studentName);
        foreach (Student.Grade g in s1.grades)
        {
          Console.WriteLine("Course={0}, Grade={1}", g.courseName, g.courseGrade);
        }
        Console.ReadLine();
    }
}
}
