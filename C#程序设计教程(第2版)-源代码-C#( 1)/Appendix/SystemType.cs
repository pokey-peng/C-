using System;using System.IO;using System.Reflection;
namespace CSharpBook.ChapterAI
{
    class Mymemberinfo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reflection.MemberInfo");
            // ��ȡType��MemberInfo
            Type MyType = Type.GetType("System.IO.File");
            MemberInfo[] Mymemberinfoarray = MyType.GetMembers();
            // ��ʾ���
            Console.WriteLine("{0}�ĳ�Ա��Ŀ�� {1}.",
                            MyType.FullName, Mymemberinfoarray.Length);
            foreach (var item in Mymemberinfoarray)
            {
                Console.WriteLine("��Ա���ƣ�{0} ��Ա���ͣ�{1}",
                                item.Name, item.MemberType.ToString());
            }
        }
    }
}
