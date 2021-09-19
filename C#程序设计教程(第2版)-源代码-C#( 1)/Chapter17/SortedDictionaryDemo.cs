using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class SortedDictionaryDemo
    {
        public static void Main()
        {
            SortedDictionary<string, string> list = new SortedDictionary<string, string>();
            list.Add("txt", "notepad.exe"); list.Add("bmp", "paint.exe");
            list.Add("jpg", "paint.exe"); list.Add("rtf", "wordpad.exe");
            foreach (var k in list.Keys) //���Ԫ��
                Console.Write("({0},{1}) ", k, list[k]);
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in list) //����foreachö��
                Console.Write("({0},{1}) ", kvp.Key, kvp.Value);
        }
    }
}
