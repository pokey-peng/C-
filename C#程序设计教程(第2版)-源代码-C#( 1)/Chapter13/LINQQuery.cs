using System; using System.Linq;
namespace CSharpBook.Chapter13
{
    class IntroToLINQ
    {
        static void Main()
        {   //����1. ��ȡ����Դ
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //����2. ������ѯ�������������з�������ż��
            //����1��ʹ�ò�ѯ����������ѯ����
            var numQuery1 = numbers.Where((num) => (num % 2) == 0);
            //����2��ʹ�ò�ѯ���ʽ������ѯ����
            var numQuery2 =         //��ѯ���������Դ洢��ѯ��
                from num in numbers  //������from�Ӿ俪ͷ��ָ������Դ�ͷ�Χ����
                where (num % 2) == 0 //ɸѡ�Ӿ䣨��ѡ��
                select num;  //������select�Ӿ䣨ѡ��������У���group�Ӿ䣨���飩��β
            //����3. ִ�в�ѯ����ʾ��ѯ���
            Console.Write("numQuery1�������£�");//����1����ѯ���ʽ����ѯ���
            foreach (var num in numQuery1) Console.Write("{0,1} ", num);
            Console.Write("\nnumQuery2�������£�"); //����2����ѯ��������ѯ���
            foreach (var num in numQuery2) Console.Write("{0,1} ", num);
            Console.ReadKey();
        }
    }
}