using System;
namespace CSharpBook.Chapter07
{
  class SimpleClassA
  {
    public SimpleClassA ()
    {
        Console.WriteLine("ִ��SimpleClassA�Ĺ��캯��");
    }
    ~SimpleClassA ()
    {
        Console.WriteLine("ִ��SimpleClassA����������");
    }
  }
  class SimpleClassB
  {
    public SimpleClassB()
    {
        Console.WriteLine("ִ��SimpleClassB�Ĺ��캯��");
    }
    ~SimpleClassB()
    {
        Console.WriteLine("ִ��SimpleClassB����������");
    }
    public void CreateObject()
    {
        Console.WriteLine("����SimpleClassB.CreateObject()");
        SimpleClassA oSimpleClassA = new SimpleClassA();
        Console.WriteLine("�˳�SimpleClassB.CreateObject()");
    }
  }
  class Test
  {
    static void Main()
    {
      Console.WriteLine("����Main()"); SimpleClassB oSimpleClassB = new SimpleClassB();
      oSimpleClassB.CreateObject(); Console.WriteLine("�˳�Main()"); Console.ReadLine();
    }
  }
}
