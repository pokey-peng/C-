using System;
class Parent {        // ����
	public void MethodA() {Console.WriteLine("����methodA()");}
}
class Child : Parent {  // ������
	public void MethodB() { Console.WriteLine("����methodB()");}
}
public class PolyMorphDemo1 {
	public static void Main() {
		Parent oParent = new Parent();
		oParent.MethodA();  // OK������ParentClass��ĳ�Ա����
		//���д����޷�������ΪParent�Ķ���ǿ��ת��Ϊ����Child
		//Child oChild1 = (Child)oParent;
		Child oChild = new Child();
		oChild.MethodB();    // OK������������Child�ĳ�Ա����
		oChild.MethodA();    // OK�����û���Parent�ĳ�Ա����
		Parent oParent1 = oChild;
		oParent1.MethodA();
		//oParent1.MethodB();   //�������Parent������MethodB�Ķ���
		Child oChild2 = (Child) oParent1;
		oChild2.MethodB();   // OK������������ChildClass�ĳ�Ա����
		oChild2.MethodA();   // OK�����û���ParentClass�ĳ�Ա����
		Console.ReadKey();
	}
}
