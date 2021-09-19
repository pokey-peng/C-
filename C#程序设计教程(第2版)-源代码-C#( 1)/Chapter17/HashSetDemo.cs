using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class HashSetDemo
    {
        public static void Main()
        {  //������Լ�
            HashSet<int> oddNumbers = new HashSet<int>(); //��������O={1,3,5,7,9}
            HashSet<int> evenNumbers = new HashSet<int>();//ż������E={0,2,4,6,8}
            HashSet<int> allNumbers = new HashSet<int>(); //��������A={0,1,2,3,4,5,6,7,8,9}
            for (int i = 0; i < 5; i++) { oddNumbers.Add(i * 2 + 1); evenNumbers.Add(2 * i); }
            for (int i = 0; i < 10; i++) allNumbers.Add(i); //HashSet����ֵ
            HashSet<int> setUnion = new HashSet<int>(oddNumbers);
            setUnion.UnionWith(evenNumbers); //����O��E
            Console.Write("O �� E = "); DisplaySet(setUnion);
            HashSet<int> setIntersect = new HashSet<int>(allNumbers); 
            setIntersect.IntersectWith(evenNumbers); //����A��E
            Console.Write("A �� E = "); DisplaySet(setIntersect);
            HashSet<int> setExcept = new HashSet<int>(allNumbers); //�A-E
            setExcept.ExceptWith(evenNumbers);
            Console.Write("A - E = "); DisplaySet(setExcept);
            HashSet<int> setSymmetricExcept = new HashSet<int>(allNumbers);
            setSymmetricExcept.SymmetricExceptWith(evenNumbers); //�ԳƲA��E
            Console.Write("A �� E = "); DisplaySet(setSymmetricExcept);
            // ���Լ���
            Console.WriteLine("ż�����Ϻ����������ص���{0}", evenNumbers.Overlaps(allNumbers));
            Console.WriteLine("�������Ϻ�ż��������ȣ�{0}", allNumbers.SetEquals(evenNumbers));
            Console.WriteLine("��������Ϊ�������ϵ��Ӽ���{0}", oddNumbers.IsSubsetOf(allNumbers));
            Console.WriteLine("��������Ϊ�������ϵĳ�����{0}", allNumbers.IsSupersetOf(oddNumbers));
            Console.WriteLine("ż������Ϊ�������ϵ����Ӽ���{0}", evenNumbers.IsProperSubsetOf(allNumbers));
            Console.WriteLine("��������Ϊż�����ϵ��泬����{0}", allNumbers.IsProperSupersetOf(evenNumbers));
        }
        private static void DisplaySet(HashSet<int> set) //��ʾ��������
        {
            Console.Write("{"); foreach (int i in set) Console.Write(" {0}", i); Console.WriteLine(" }");
        }
    }
}
