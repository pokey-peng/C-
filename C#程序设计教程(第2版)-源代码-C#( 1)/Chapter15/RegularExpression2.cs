using System;using System.Text.RegularExpressions;
namespace CSharpBook.Chapter15
{
class RegularExpressionDemo2
{
    static void Main(string[] args)
    {
        String strIn = @"~@ How are you doing? Fine, thanks.!"; 
        //���������.�����㣩����?�����ʺţ����ո�͡�,�������㣩��������з���ĸ�����ַ�
        String results = Regex.Replace(strIn, @"[^\w\. ?,]", ""); 
        Console.WriteLine(strIn); Console.WriteLine(results); Console.ReadKey();
    }
}
}
