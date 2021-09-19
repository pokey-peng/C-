using System;
namespace CSharpBook.Chapter12
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
                    AllowMultiple = true)  //������ʵ��Ӧ�ö�θ�����
    ]
    public class AuthorAttribute : Attribute
    {
        string name; public double version; //�����������汾
        public AuthorAttribute(string name)
        {
            this.name = name; version = 1.0; //��������������Ĭ�ϰ汾ֵ
        }
        public string GetName()  //��ȡ����������Ϣ
        {
            return name;
        }
    }
    [Author("Qingsong YU")]
    class FirstClass { }
    //����������
    class SecondClass {  }
    [Author("Qingsong YU"), Author("Angela", version = 2.0)]
    class ThirdClass {   }
    class TestAuthorAttribute
    {
        static void Main()
        {  //��ӡ3λ���ߵ���Ϣ
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
            PrintAuthorInfo(typeof(ThirdClass)); Console.ReadKey();
        }
        private static void PrintAuthorInfo(System.Type t)
        {
            Console.WriteLine("{0} ��������Ϣ��", t);
            Attribute[] attrs = Attribute.GetCustomAttributes(t);//���似��
            foreach (Attribute attr in attrs)
            {
                if (attr is AuthorAttribute)
                {
                    AuthorAttribute a = (AuthorAttribute)attr;
                    Console.Write("{0}, �汾 {1:f}\n", a.GetName(), a.version);
                }
            }
        }
    }
}
