// compile��csc /unsafe VoidPointer.cs  ->  VoidPointer.exe
using System;
namespace CSharpBook.Chapter05
{
    unsafe class VoidPointer
    {
        static void Main()
        {   //pv��ָ��δ֪���͵�ָ�룬pi��ָ��������ָ��
            //ע�⣺һԪ���Ѱַ�������*����������voidָ��
            //ʹ��ǿ��ת����voidָ��ת��Ϊ������int��ָ������
            int i = 10;  void* pv = &i;  int* pi = (int*)pv;
            Console.WriteLine("i={0}, pi={1:X},pv={2:X}, &i={3:X}, *pi={4}", i, (int)pi, (int)pv, (int)&i, *pi);
        }
    }
}
