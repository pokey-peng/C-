using System;
namespace CSharpBook.Chapter02
{
    public class TestVariableScope
    {
        static int j = 99;           //��̬����j����TestVariableScope��
        public static void Main()
        {
          //String[] args ="abc";//args��main�����Ĳ���args��������ͬ����ͻ��ע�ʹ��������г���
            for (int i = 0; i < 3; i++)  //�ֲ�����i���ڵ�ǰ��for���
            {
                int k = 10;         //�ֲ�����k���ڵ�ǰ��for���
                Console.WriteLine(k + " * " + i + " = " + k * i);
            } //�ֲ�����i��k�������򵽴�Ϊֹ
            // System.out.println(i);    //�ֲ�����i�����ڣ��������ע�ʹ��������г���
            int j = 20;               //����ֲ�����j������ľ�̬����j����ͻ
            Console.WriteLine("class j=" + TestVariableScope.j);
            Console.WriteLine("local j=" + j);
            for (int i = 0; i < 3; i++) //�ֲ�����i���ڵ�ǰ��for��䣬���¶���ֲ�����i�����ͻ
            {
                int k = 20;       //�ֲ�����k���ڵ�ǰ��for��䣬���¶���ֲ�����k�����ͻ
                // int j = 20;      //�ظ��������ֲ�������ͻ���������ע�ʹ��������г���
                Console.WriteLine(k + " * " + i + " = " + k * i);
            }
            Console.ReadKey();
        }
    }
}
