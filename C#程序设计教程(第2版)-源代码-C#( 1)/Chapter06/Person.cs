// compile��csc /t:library Person.cs  --> Person.dll
using System;
namespace CSharpBook.Chapter06
{
  public class Person
  {
	public String name; protected int age; //������public�������䣨protected��
	public Person() {               //���������Ĺ��췽��
		this.name = "δ֪"; this.age = 0;
	}
	public Person(String name, int age) { //��2�������Ĺ��췽��
		this.name = name; this.age = age;
	}
	public void print() {             //�����Ա��Ϣ
		Console.WriteLine("name={0}, age={1}", this.name, this.age);
	}
  }
}
