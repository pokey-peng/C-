using System;
class Parent
{
    public virtual void MethodF(){Console.WriteLine("����Parent��MethodF()");}
    public virtual void MethodG() { Console.WriteLine("����Parent��MethodG()"); }
}
class Child : Parent
{
    public sealed override void MethodF()//�ܷⷽ������д�ӻ���̳еķ���MethodF()
    {
        Console.WriteLine("����Child��MethodF()");
    }
    public override void MethodG() //��д�ӻ���̳еķ���
    {
        Console.WriteLine("����Child��MethodG()");
    }
}
sealed class Final : Child //�ܷ���
{
    //public override void MethodF()//������󡣼̳г�ԱChild.MethodF()��sealed���޷���д
    //{    
    //    Console.WriteLine("����Final��MethodF()");
    //}
    public override void MethodG() //��д�ӻ���̳еķ���
    {
        Console.WriteLine("����Final��MethodG()");
    }
}
//sealed class Final1 : Final{} //��������޷����ܷ���Final����
public class FinalDemo
{
    static void Main()
    {
        Final obj = new Final(); obj.MethodF();
        obj.MethodG(); Console.ReadKey();
    }
}
