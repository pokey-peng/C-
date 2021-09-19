using System;using System.Collections;
namespace CSharpBook.Chapter15
{
    class Vowels
    {
        static void Main(string[] args)
        {
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0, countAll = 0;
            Console.WriteLine("�������ַ�����"); String str = Console.ReadLine();
            str = str.ToUpper(); char[] chars = str.ToCharArray();
            foreach (char ch in chars)
            {
                countAll++;   //ͳ����ĸ����
                switch (ch)
                {
                    case 'A': //ͳ��Ԫ��'A'��'a'�ĳ��ִ���
                        countA++; break;
                    case 'E': //ͳ��Ԫ��'E'��'e'�ĳ��ִ���
                        countE++; break;
                    case 'I': //ͳ��Ԫ��'I'��'i'�ĳ��ִ���
                        countI++; break;
                    case 'O': //ͳ��Ԫ��'O'��'o'�ĳ��ִ���
                        countO++; break;
                    case 'U': //ͳ��Ԫ��'U'��'u'�ĳ��ִ���
                        countU++; break;
                    default:
                        break;
                }
            }
            Console.WriteLine("������ĸ������Ϊ��{0}", countAll);
            Console.WriteLine("Ԫ����ĸ���ֵĴ�����Ƶ�ʷֱ�Ϊ��");
            Console.WriteLine("A��\t{0}\t{1:#.00%}", countA, countA * 1.0 / countAll);
            Console.WriteLine("E��\t{0}\t{1:#.00%}", countE, countE * 1.0 / countAll);
            Console.WriteLine("I��\t{0}\t{1:#.00%}", countI, countI * 1.0 / countAll);
            Console.WriteLine("O��\t{0}\t{1:#.00%}", countO, countO * 1.0 / countAll);
            Console.WriteLine("U��\t{0}\t{1:#.00%}", countU, countU * 1.0 / countAll);
            Console.ReadKey();
        }
    }
}
