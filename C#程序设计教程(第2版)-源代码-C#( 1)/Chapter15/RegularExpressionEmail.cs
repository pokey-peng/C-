using System;using System.Text.RegularExpressions;
namespace CSharpBook.Chapter15
{
class RegularExpressionEmail
{
    static void Main(string[] args)
    {  //��Ч�ĵ����ʼ�������ʽ��ʽ
       String pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
       String strIn1 = "hjiang@yahoo.com";    //��Ч�ĵ�������
       bool b1 = Regex.IsMatch(strIn1, pattern);
       String strIn2 = "hjiang.yahoo.com";     //��Ч�ĵ�������
       bool b2 = Regex.IsMatch(strIn2, pattern);
       Console.WriteLine("hjiang@yahoo.com����Ч�ĵ����ʼ���ʽ��"+b1);
       Console.WriteLine("hjiang.yahoo.com����Ч�ĵ����ʼ���ʽ��" +b2); Console.ReadKey();
    }
}
}
