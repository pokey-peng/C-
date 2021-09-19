using System;
namespace CSharpBook.Chapter07
{
  class Celsius   //�����¶�
  {
    private float degrees;
    public Celsius(float temp)  //���캯��
    {
        degrees = temp;
    }
    public static explicit operator Fahrenheit(Celsius c) //��ʽǿ��ת��
    {   // �����¶�ת��Ϊ�����¶�
        return new Fahrenheit((9.0f / 5.0f) * c.degrees + 32);
    }
    public float Degrees
    {
        get { return degrees; }
    }
  }
  class Fahrenheit   //�����¶�
  {
    private float degrees;
    public Fahrenheit(float temp)  //���캯��
    {
        degrees = temp;
    }
    public static implicit operator Celsius(Fahrenheit f) //��ʽ�Զ�ת��
    {   // �����¶�ת��Ϊ�����¶�
        return new Celsius((5.0f / 9.0f) * (f.degrees - 32));
    }
    public float Degrees
    {
        get { return degrees; }
    }
  }
  class MainClass
  {
    static void Main()
    {
        Fahrenheit f = new Fahrenheit(100.0f);
        Console.Write("{0} �����¶�", f.Degrees);
        Celsius c = f;            //��ʽ�Զ�ת��
        Console.WriteLine("\n = {0} �����¶�", c.Degrees);
        Fahrenheit f2 = (Fahrenheit)c;    //��ʽǿ��ת��
        Console.WriteLine(" = {0}�����¶�", f2.Degrees);  Console.ReadLine();
    }
  }
}
