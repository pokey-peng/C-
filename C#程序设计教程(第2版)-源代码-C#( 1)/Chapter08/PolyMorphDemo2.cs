using System;
interface ICommon { void f();}
abstract class Base { public abstract void g();}
class Derived1 : Base, ICommon
{   //��д�ӻ��ӿ�ICommon�̳еķ���f()
    public override void f() { Console.Write("Derived1.f()"); }
    public void g() { Console.Write("Derived1.g()"); }//��д�ӻ���̳еķ���g()
    public void h() { Console.Write("Derived1.h()"); }//�¶��巽��h()
}
class Derived2 : ICommon
{   //��д�ӻ��ӿ�ICommon�̳еķ���f()
    public void f() { Console.Write("Derived2.f()"); }
    public void h() { Console.Write("Derived2.h()"); } // �¶��巽��h()
}
public class PolyMorphDemo2
{
    public static void Main()
   {//Derived1����ʵ��d1����ΪDerived���ͣ��ʿɵ���Derived1�༰��̳е����г�Ա����
        Derived1 d1 = new Derived1(); d1.f(); d1.g(); d1.h();
      //Derived1����ʵ��c1����ΪICommon�ӿڣ��ʿɵ���ICommon�ӿڵ����г�Ա����
        ICommon c1 = new Derived1(); c1.f();
      //Derived1����ʵ��b1����ΪBase���ͣ��ʿɵ���Base���͵����г�Ա����
        Base b1 = new Derived1();
        b1.g();       //����Derived1����д�ķ���f()
        //b1.f();      //�������Base��û����������f() 
      // Derived1����ʵ��o1����ΪObject���ͣ��ʿɵ���Object���͵����г�Ա����
        Object o1 = new Derived1();
        Console.WriteLine(o1.GetType()); //����Object��ʵ�ֵķ���GetType()
        //o1.f();     //�������Object��û����������f()
        //Base b2 = new Derived2(); //�������Derived2����ʵ�����ܱ���ΪBase����
    }
}
