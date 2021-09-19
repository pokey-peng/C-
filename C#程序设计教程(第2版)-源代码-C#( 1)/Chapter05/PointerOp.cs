// compile��csc /unsafe 5-11-PointerOp.cs  -> 5-11-PointerOp.exe
using System;
namespace CSharpBook.Chapter05
{
    struct CoOrds  // ƽ�������
    {
        public int x;  public int y;
    }
    unsafe class PointerOp
    {
        static void Main()
        {   //��1����ȡ�����ĵ�ַ�ͱ�����ֵ����ͨ��ָ��������ı�����ֵ
            int number=10;
            int* pi = &number; // ������number�ĵ�ַ����ָ�����pi
            Console.WriteLine("����numberԭʼ��ֵ = {0}", number);
            Console.WriteLine("*piԭʼ��ֵ = {0}", *pi); // ��ӡ*pԭʼ��ֵ
            // ��ӡpi��ֵ��������number�ĵ�ַ��
            Console.WriteLine("pi��������number�ĵ�ַ�� = {0:X}", (int)pi);
            *pi = 20; // ͨ��ָ�������������number��ֵ
            Console.WriteLine("ָ�������*pi��ֵ = {0}", *pi); // ��ӡ*pi��ֵ
            // ��ӡ����number���ĺ��ֵ
            Console.WriteLine("ָ�����������number��ֵ = {0}", number);
            //��2��ͨ��ָ����ʳ�Ա
            CoOrds school;  // ѧУ����
            CoOrds* p = &school;
            p->x = 25; p->y = 12;     // ѧУ����x��y
            Console.WriteLine("\n(p->x��ʽ��ӡ)ѧУ������ֵ �� x={0}, y={1}", p->x, p->y);
            //���ʽ p->x ��Ч�ڱ��ʽ (*p).x��ʹ�����������ʽ�ɻ����ͬ�Ľ��
            Console.WriteLine("(*p).x��ʽ��ӡ)ѧУ������ֵ �� x={0}, y={1}", (*p).x, (*p).y);
            //��3��ͨ��ָ���������Ԫ��
            char* charPointer = stackalloc char[123]; //�ڶ�ջ�Ϸ����ڴ�
            for (int i = 65; i < 123; i++)
            {
                charPointer[i] = (char)i;         // �ȼ��� *(charPointer+i) = (char)i;
            }
            // ��ӡ��д��ĸ
            Console.Write ("\n��д��ĸ��");
            for (int i = 65; i < 91; i++)
            {
                Console.Write(charPointer[i]);   // �ȼ��� Console.Write(*(charPointer+i));
            }
            // ��ӡСд��ĸ
            Console.Write ("\nСд��ĸ��");
            for (int i = 97; i < 123; i++)
            {
                Console.Write(charPointer[i]);  // �ȼ��� Console.Write(*(charPointer+i));
            }
            Console.WriteLine("\n");
            //��4�������͵ݼ�ָ��
            // ͨ����ָ������int�Ĵ�С������һ�����顣����ÿһ��������ʾ����Ԫ�ص����ݺ͵�ַ
            int[] numbers = { 0, 1, 2, 3, 4 };
            // �������ַ����ָ��
            fixed (int* p1 = numbers)  //��ʱ�̶�һ���������Ի�ȡ���ַ
            {  // ��������Ԫ��
                for (int* p2 = p1; p2 < p1 + numbers.Length; p2++)
                {
                    Console.WriteLine("����Ԫ�ص����ݣ�{0}�� ��ַ��{1:X}", *p2, (int)p2);
                }
            }
            //��5��ʹ�����������+��-������ָ��
            int* memory = stackalloc int[30];
            long* difference;
            int* pi1 = &memory[4];
            int* pi2 = &memory[10];
            difference = (long*)(pi2 - pi1);
            Console.WriteLine("\nָ�루&memory[10]-&memory[4]������Ĳ�Ϊ�� {0}\n", (long)difference);
            //��6��ָ��Ƚ�
            int x = 234;  int y = 236;  int* px = &x;  int* py = &y;
            Console.WriteLine("xΪ{0}, yΪ{1}, pxΪ{2:X}, pyΪ{3:X}", x ,y, (int)px, (int)py);
            Console.WriteLine("ָ��Ƚϣ�px>pyΪ{0}, px<pyΪ{1}",  px > py,  px < py);
        }
    }
}
