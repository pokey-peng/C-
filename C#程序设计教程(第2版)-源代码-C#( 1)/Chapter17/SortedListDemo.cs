using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class SortedListDemo
    {
        public static void Main()
        {
            SortedList list = new SortedList(); //����Listʵ������
            list.Add(5, "Friday"); list.Add(6, "Saturday"); list.Add(7, "Sunday"); list.Add(1, "Monday");
            list.Add(2, "Tuesday"); list.Add(3, "Wednesdy"); list.Add(4, "Thursday");
            list.Remove(7);  //ʹ��Remove����ɾ������7λ�õ�Ԫ��
            list.RemoveAt(5); //ʹ��RemoveAt����ɾ������2λ�õ�Ԫ��
            for (int i = 0; i < list.Count; i++) //���Ԫ��
                Console.Write("({0},{1}) ", list.GetKey(i), list.GetByIndex(i));
            Console.WriteLine();
            foreach (DictionaryEntry de in list) //����foreachö��
                Console.Write("({0},{1}) ", de.Key, de.Value);
            Console.ReadKey();
        }
    }
}
