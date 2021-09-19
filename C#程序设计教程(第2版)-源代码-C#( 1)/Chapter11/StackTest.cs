using System;
public class Stack<T>
{
    int pos;
    T[] data = new T[100];
    public void Push(T obj) { data[pos++] = obj; }//��ջ
    public T Pop() { return data[--pos]; }        //��ջ
}
public class StackTest
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(2); stack.Push(4);   //���ݽ�ջ
        //stack.Push("a");            //�������
        Console.WriteLine(stack.Pop()); //��������4
        Console.ReadKey();
    }
}
