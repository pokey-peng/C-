//�������csc /r:Dog1.dll DogTest.cs
//����ɹ���csc /r:Dog2.dll DogTest.cs  ->  DogTest.exe
namespace CSharpBook.Chapter06
{
  class DogTest
  {
    static void Main(string[] args)
    {
        Dog dog1= new Dog();    // ��������
        dog1.SayHello();         // ����public��Ա
        System.Console.ReadKey();
    }
  }
}
