using System;
namespace CSharpBook.Chapter03
{
    class LogicalTest
    {
        static bool Method1()
        {
            Console.WriteLine("����Method1������False");
            return false;
        }
        static bool Method2()
        {
            Console.WriteLine("����Method2������True");
            return true;
        }
        static void Main()
        {   // �߼����ǡ�
            Console.WriteLine("!true={0}, !false={1}", !true, !false);
            // �߼����롱& �������롱
            Console.WriteLine("�߼����롱(&):");
            Console.WriteLine("Method1()&Method2()�����{0}", Method1() & Method2());
            Console.WriteLine("�������롱(&&):");
            Console.WriteLine("Method1()&&Method2()�����{0}", Method1() && Method2());
            Console.WriteLine("λ�߼���: 0xf8 & 0x3f = 0x{0:x}", 0xf8 & 0x3f); 
            // �߼�����& ��������
            Console.WriteLine("�߼�����(|):");
            Console.WriteLine("Method2()|Method1()�����{0}", Method2() | Method1());
            Console.WriteLine("��������(||):");
            Console.WriteLine("Method2()||Method1()�����{0}", Method2() || Method1());
            Console.WriteLine("λ�߼���: 0xf8 | 0x3f = 0x{0:x}", 0xf8 | 0x3f);   
            // �߼������
            Console.WriteLine("true^false={0}, false^false={1}", true ^ false, false ^ false);
            Console.WriteLine("λ�߼����: 0xf8 ^ 0x3f = 0x{0:x}", 0xf8 ^ 0x3f);
            // ����߼�����
            Console.WriteLine("true^!false&false|false={0}",true^!false&false|false);
            Console.ReadKey(); 
        }
    }
}
