// compile��csc /r:Person.dll ClassCompareTest.cs  ->  ClassCompareTest.exe
using System;
namespace CSharpBook.Chapter06
{
  class ClassCompareTest
  {
    static void Main(string[] args)
    {
        Person personA = new Person ("ZhangSan",25); //��������1
        Person personB = new Person ("LiSi",18);     //��������2
        if (personA == personB)        //�Ƚ϶���
        {
            Console.WriteLine("personA��personB��ͬ��");
        }else{
            Console.WriteLine("personA��personB��ͬ��");
        }
        personB = personA; 
        if (personA == personB)       //�Ƚ϶���
        {
            Console.WriteLine("personA��personB��ͬ��");
        }else{
            Console.WriteLine("personA��personB��ͬ��");
        }
        personB.name = "WangWu"; 
        Console.WriteLine("PersonB��s name: {0}", personB.name);
        Console.WriteLine("PersonA��s name: {0}", personA.name);
        Console.ReadKey();
    }
  }
}
