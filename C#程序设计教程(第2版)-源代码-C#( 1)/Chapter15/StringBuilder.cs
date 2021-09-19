using System;using System.Text;
namespace CSharpBook.Chapter15
{
    public sealed class StringBuilderTest
    {
        static void Main()
        {//����StringBuilder����ʹ�����ɴ��50���ַ�����ʼ��StringBuilder����Ϊ��"ABC"
            StringBuilder sb = new StringBuilder("ABC", 50);
            sb.Append(new char[] { 'D', 'E', 'F' });  //׷��3���ַ�
            sb.AppendFormat("GHI{0}{1}", 'J', 'k'); //׷�Ӹ�ʽ���ַ���
            Console.WriteLine("{0} chars������Ϊ��{1}", sb.Length, sb.ToString());//��ʾ���Ⱥ�����
            sb.Insert(0, "Alphabet---");//����ǰ������ַ���
            sb.Replace('k', 'K'); //������Сд��ĸk�滻Ϊ��д��ĸK
            Console.WriteLine("{0} chars������Ϊ��{1}", sb.Length, sb.ToString());//��ʾ���Ⱥ�����
            Console.ReadLine();
        }
    }
}
