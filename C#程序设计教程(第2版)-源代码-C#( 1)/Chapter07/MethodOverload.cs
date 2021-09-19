using System;
namespace CSharpBook.Chapter07
{
  class OverloadExample
  {
    public void SampleMethod(double i) 
    {
        Console.WriteLine("SampleMethod(double i):{0}", i);
    }
    public void SampleMethod(int i) 
    {
        Console.WriteLine("SampleMethod(int i):{0}", i);
    }
    public void SampleMethod(ref int i) 
    {
        Console.WriteLine("SampleMethod(ref int i):{0}", i);
    }
    //public void SampleMethod(out int i) { }     //�������
    static void Main()
    {
        OverloadExample o = new OverloadExample();
        int i = 10;  double d = 11.1;
        o.SampleMethod(i);     //����SampleMethod(int i)
        o.SampleMethod(d);    //����SampleMethod(double i)
        o.SampleMethod(ref i);  //����SampleMethod(ref int i)
        Console.ReadLine();
    } 
  }
}
