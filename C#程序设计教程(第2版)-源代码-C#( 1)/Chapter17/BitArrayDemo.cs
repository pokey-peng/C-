using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class BitArrayDemo
    {
        public static void Main()
        {  //����2��ͬ�����ȵ�BitArrays��Ȼ��ֵ����ʾ
            BitArray ba1 = new BitArray(4); BitArray ba2 = new BitArray(4);
            ba1.SetAll(true); PrintValues("ba1", ba1); //��ba1����ֵ����Ϊtrue����ʾba1
            ba1.Set(ba1.Count - 1, false); PrintValues("ba1", ba1);//ba1ĩԪ��ֵ����Ϊfalse����ʾba1
            Console.Write("\nba1ǰ2��Ԫ�ص�ֵ��{0} {1}", ba1.Get(0), ba1.Get(1));
            ba2[0] = ba2[2] = false; ba2[1] = ba2[3] = true; PrintValues("ba2", ba2);//ba2��ֵ����ʾ
            ba1.SetAll(true); ba1.Not();  //��λNOT��������תBitArray1������λֵ
            PrintValues("Not ba1", ba1); //��ʾba1
            ba1.SetAll(true); PrintValues("ba1 And ba2", ba1.And(ba2));//��λAND����
            ba1.SetAll(true); PrintValues("ba1 Or ba2", ba1.Or(ba2));//��λOR����
            ba1.SetAll(true); PrintValues("ba1 Xor ba2", ba1.Xor(ba2));//��λXOR����
        }
        public static void PrintValues(string name, IEnumerable myList) //��ʾBitArray������
        {
            Console.Write("\n{0} = ", name);
            foreach (Object obj in myList) Console.Write("{0} ", obj);
        }
    }
}
