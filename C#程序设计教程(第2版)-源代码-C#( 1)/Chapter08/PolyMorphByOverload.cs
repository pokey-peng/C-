using System;
class P0 // ����
{ 
    public void MethodA(){Console.WriteLine("������P0�ķ���methodA()");}
}
class C0 : P0 // ������
{ 
    public void MethodA(String str1) //���ط��������شӻ���̳е�MethodA()
    { 
      Console.WriteLine("������C0�ķ���MethodA()��" + str1);
    }
    public void MethodB(String str1) //���ط���������MethodB(int a)
    { 
      Console.WriteLine("����C0���ʵ������MethodB(String str1)��" + str1);
    }
    public void MethodB(int a) // ���ط���������MethodB(String str1)
    { 
      Console.WriteLine("����C0���ʵ������MethodB(int a)��" + a);
    }
}
public class PolyMorphByOverload
{
    public static void Main()
    {
      C0 obj0 = new C0();
      obj0.MethodA("abc"); //��̬�󶨵�C0�Ķ���ʵ����ʵ������MethodA(String str1)
      obj0.MethodB("xyz");//��̬�󶨵�C0�Ķ���ʵ����ʵ������MethodB(String str1)
      obj0.MethodB(123); //��̬�󶨵�C0�Ķ���ʵ����ʵ������MethodB(int a)
      Console.ReadKey();
    }
}
