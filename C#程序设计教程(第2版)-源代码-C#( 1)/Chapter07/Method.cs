using System;
namespace CSharpBook.Chapter07
{
  class SimpleMath
  {
    public int AddTwoNumbers(int number1, int number2) //�������
    {
        return number1 + number2;
    }
    public int SquareANumber(int number) //��ĳ����ƽ��
    {
        return number * number;
    }
    public static void DisplayResult(int number) //��ʾ���
    { 
        Console.WriteLine("���Ϊ��{0}", number);
    }
  }
  class SimpleMathTest
  {
    public static void Main()
    {
        int result; SimpleMath obj=new SimpleMath();
        result=obj.AddTwoNumbers(1, 2);  //�������
        SimpleMath.DisplayResult(result);  //��ʾ��ӽ��
        SimpleMath.DisplayResult(obj.SquareANumber(result)); //��ʾĳ����ƽ��
        Console.ReadLine();
    }
  }
}
