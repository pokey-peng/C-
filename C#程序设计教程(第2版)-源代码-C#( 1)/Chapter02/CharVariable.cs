using System;
namespace CSharpBook.Chapter02
{
    class CharVariable
    {
        static void Main(string[] args)
        {
            //char char0 = "Z";    //ʹ��˫���Ż�����������
            char ch1 = 'X';        //�ַ�����
            char ch2 = '\x0058';   //16���Ʊ���
            char ch3 = (char)88;   //������ת��
            char ch4 = '\u0058';   //Unicode
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", ch1, ch2, ch3, ch4);
            Console.WriteLine("{0}��Сд��ĸ�ǣ�{1}", ch1, Char.ToLower(ch1));
            Console.WriteLine("{0}����ĸ��{1}", ch1, Char.IsLetter(ch1)); Console.ReadLine();
            Console.ReadKey();
        }
    }
}
