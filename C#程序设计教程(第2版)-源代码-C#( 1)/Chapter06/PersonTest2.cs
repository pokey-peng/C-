// compile��csc /r:Person.dll PersonTest2.cs  ->  PersonTest2.exe
using System;
namespace CSharpBook.Chapter06
{
  class PersonTest2
  {
    static void Main(string[] args)
    {
		Person personA;                //����Person���ͱ���
		personA = new Person("����", 25); //����Person����ʵ������ֵ������personA
		Person personB = new Person("����", 18); //�������󣺵��ô�2�������Ĺ��췽��
		Person personC = new Person();         //�������󣺵��ò��������Ĺ��췽��
		personC.name = "����";                 //���ʶ����Ա����
		personA.print(); personB.print(); personC.print();//���ʶ��󷽷�
    }
  }
}
