using System;
namespace CSharpBook.Chapter07
{
  class Container
  {
    protected string name = "Container";
    private void sayHello()
    {
        Console.WriteLine("Hello, Container!");
    }
    public class Nested  // Ƕ����
    {
        protected string name = "Nested:";
        public void sayHello()
        {
            Container c = new Container();
            Console.WriteLine("Contatiner c.name={0}",c.name);
            //���ð�����Container��protected�ֶ�
            c.sayHello(); //���ð�����Container��private����sayHello()
        }
    }
  }
  class Test
  {
    static void Main()
    {
      Container.Nested n = new Container.Nested(); n.sayHello(); Console.ReadKey();
    }
  }
}
