using System;
namespace CSharpBook.Chapter07
{
    class Counter
    {
        public int number;      //ʵ���ֶ�
        public static int count;   //��̬�ֶ�
        public Counter()       //���캯��
        {
            count = count + 1; number = count;
        }
        public void showInstance()
        {
            Console.Write("object{0} :", number);  //��ȷ��ʵ�������ڿ�ֱ������ʵ���ֶ�
            Console.WriteLine("count={0}", count);//��ȷ��ʵ�������ڿ�ֱ�����þ�̬�ֶ�
        }
        public static void showStatic()
        {
            //Console.Write("object{0} :", number); //���󣺾�̬�����ڲ���ֱ������ʵ���ֶ�
            Console.WriteLine("count={0}", count); //��ȷ����̬�����ڿ���ֱ�����þ�̬�ֶ�
        }
    }
    class CounterTest
    {
        public static void Main()
        {
            Counter c1 = new Counter();           //��������
            c1.showInstance();                   //��ȷ���ö������ʵ������
            //c1.showStatic();                     //���󣺲����ö�����þ�̬����
            Console.Write("object{0} :", c1.number); //��ȷ���ö�������ʵ���ֶ�
            //Console.Write("object{0} :", Counter.number); //���󣺲�������������ʵ���ֶ�
            //Console.WriteLine("count={1}", c1.count); //���󣺲����ö��������þ�̬�ֶ�
            Counter.showStatic();                   //��ȷ�����������þ�̬����
            //Counter.showInstance ();               //���󣺲�������������ʵ������
            Counter c2 = new Counter();             //��������
            c1.showInstance(); c2.showInstance(); Console.ReadKey();
        }
    }
}
