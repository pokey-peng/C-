using System;
public class ObjectTest {
	public static void Main( ) {
		Object[] objs = new Object[3];
		objs[0] = 123;          // �������objs[0]��ֵ��123��Int32���ͣ�
		objs[1] = "abc";        // �������objs[1]��ֵ��"abc"��String���ͣ�
        objs[2] = new DateTime(2014, 7, 18);   // �������objs[2]��ֵ����ǰ����ʱ��
		for (int i = 0; i < objs.Length; i++) {
			Console.Write("object[{0}]: {1}, {2}, {3}, {4} \n", i, objs[i],
					(objs[i]).GetType(), (objs[i]).ToString(), (objs[i]).GetHashCode());
		}
		Object obj1 = objs[0];
		Object obj2 = objs[1];
		Console.Write("compare  obj1.equals(obj2): {0} \n", obj1.Equals(obj2));
		obj1 = obj2;
		Console.Write("compare  obj1.equals(obj2): {0} \n", obj1.Equals(obj2));
        Console.ReadKey();
	}
}