using System;
namespace CSharpBook.Chapter12
{
    public class CallerTest
    {
        public static void TraceMessage(string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine("��Ϣ: " + message);
            Console.WriteLine("��Ա����: " + memberName);
            Console.WriteLine("Դ����·��: " + sourceFilePath);
            Console.WriteLine("�к�: " + sourceLineNumber);
        }
        public static void f1() { TraceMessage("CallerTest.f1()"); }
        public static void Main()
        {
            TraceMessage("Main()");CallerTest.f1();Console.ReadKey();
        }
    }
}
