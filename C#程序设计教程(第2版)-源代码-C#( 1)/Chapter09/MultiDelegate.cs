using System;
namespace CSharpBook.Chapter09
{
    delegate void D(int x);
    class C
    {
        public static void M1(int i) { Console.WriteLine("C.M1: " + i);} 
        public static void M2(int i) { Console.WriteLine("C.M2: " + i);}
    }
    class Test
    {
        static void Main()
        {  D cd1 = new D(C.M1);  cd1(-1); //���� M1
           D cd2 = new D(C.M2);  cd2(-2); //����M2
           D cd3 = cd1 + cd2; 	cd3(10);   //�ȵ���M1��Ȼ�����M2
           cd3 -= cd1;  cd3(20); //ɾ��M1������M2
           cd3 -= cd2;        //ɾ��M2�󣬵����б�Ϊnull
           // cd3(70);         //�׳�System.NullReferenceException�쳣
           cd3 -= cd1;        //û��M1��ɾ������������
           Console.ReadLine();
        }
    }
}
