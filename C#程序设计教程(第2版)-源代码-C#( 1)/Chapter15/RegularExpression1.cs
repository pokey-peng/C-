using System;using System.Text.RegularExpressions;
namespace CSharpBook.Chapter15
{
    class RegularExpressionDemo1
    {
        static void Main(string[] args)
        {
            MatchCollection mc;
            String[] results = new String[20]; int[] matchposition = new int[20];
            Regex r = new Regex("abc");   //����Regex���󣬲�����������ʽ
            mc = r.Matches("123abc4abcd");//ʹ��Matches������������ƥ����
            Console.WriteLine("Դ�ַ���   = " + "123abc4abcd");
            Console.WriteLine("ƥ���ַ��� = " + "abc");
            for (int i = 0; i < mc.Count; i++) // ͨ��ѭ����������ƥ�����λ��
            {  
                results[i] = mc[i].Value; //��ƥ���string��ӵ�string������
                matchposition[i] = mc[i].Index; // ��¼ƥ����ַ�λ��
                Console.WriteLine("����λ�� = {0}�� ��� = {1}", mc[i].Index, mc[i].Value);
            }
            Console.ReadKey();
        }
    }
}