using System;
namespace CSharpBook.Chapter04
{
    class Sequence
    {
       static void Main()
        {
           double a, b, c, p, area;
           Console.Write("�����������εı�A��   ");
           a = double.Parse(Console.ReadLine());       //�������ַ���ת��Ϊ��Ч��˫���ȸ�����
           Console.Write("�����������εı�B��   ");
           b = double.Parse(Console.ReadLine());
           Console.Write("�����������εı�C��   ");
           c = double.Parse(Console.ReadLine());
           Console.WriteLine("���������߷ֱ�Ϊ�� a={0}, b={1}, c={2}", a,b,c);
           p = (a + b + c) / 2; area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
           Console.WriteLine("�����ε���� = {0}",area);  Console.ReadLine();
        }
    }
}
