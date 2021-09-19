using System;
namespace CSharpBook.Chapter07
{
  public static class TemperatureConverter
  {
    public static double CelsiusToFahrenheit(string temperatureCelsius)//���ϵ������¶ȵ�ת��
    {  
        double celsius = Double.Parse(temperatureCelsius);//����ת��Ϊdouble����
        double fahrenheit = (celsius * 9 / 5) + 32;       //����ת���������¶�
        return fahrenheit;
    }
    public static double FahrenheitToCelsius(string temperatureFahrenheit)//���ϵ������¶ȵ�ת��
    {   
        double fahrenheit = Double.Parse(temperatureFahrenheit);//����ת��Ϊdouble����
        double celsius = (fahrenheit - 32) * 5 / 9;             //����ת���������¶�
        return celsius;
    }
  }
  class TestTemperatureConverter
  {
    static void Main()
    {
        Console.WriteLine("1. �������¶ȵ������¶�.");
        Console.WriteLine("2. �ӻ����¶ȵ������¶�.");
        Console.Write("��ѡ��ת������");
        string selection = Console.ReadLine();
        double F, C = 0;
        switch (selection)
        {
            case "1":
                Console.Write("�����������¶ȣ� ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                Console.WriteLine("�����¶�Ϊ�� {0:F2}", F); break;
            case "2":
                Console.Write("�����뻪���¶ȣ� ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                Console.WriteLine("�����¶�Ϊ�� {0:F2}", C); break;
            default:
                Console.WriteLine("�޴�ѡ�ֻ��ѡ��1��2��"); break;
        }
        Console.ReadLine();
    }
  }
}
