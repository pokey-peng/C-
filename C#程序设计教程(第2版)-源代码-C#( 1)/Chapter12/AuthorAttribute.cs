using System;
namespace CSharpBook.Chapter12
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct,
                      AllowMultiple = true)  //������ʵ��Ӧ�ö�θ�����
    ]
    public class AuthorAttribute : System.Attribute
    {
        private string name; public double version;
        public AuthorAttribute(string name)
        {
            this.name = name; version = 1.0;
        }
    }
    [Author("Qingsong YU", version = 1.1)]
    [Author("Hong JIANG", version = 1.2)]
    class SampleClass
    {   //��д����Qingsong YU�Ĵ���...
        //��д����Hong JIANG�Ĵ���...
        public static void Main() //������
        {
          Console.WriteLine("Hello!"); Console.ReadLine();
        }
    }
}
