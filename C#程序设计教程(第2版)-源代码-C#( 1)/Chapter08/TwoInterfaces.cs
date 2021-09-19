using System;
namespace CSharpBook.Chapter08 
{ 
  interface IEnglishDimensions //�����ӿ�IEnglishDimensions����Ӣ��inchΪ��λ��
  {
    float Length();  float Width();
  }
  interface IMetricDimensions //�����ӿ�IMetricDimensions���Թ���cmΪ��λ��
  {
    float Length();  float Width();
  }
//����������Box��ʵ�������ӿ�IEnglishDimensions��IMetricDimensions
class Box : IEnglishDimensions, IMetricDimensions
  {
    float lengthInches;  float widthInches;
    public Box(float length, float width)
    {
        lengthInches = length;  widthInches = width;
    }
    // ��ʽʵ��IEnglishDimensions�еĳ�Ա
    float IEnglishDimensions.Length() { return lengthInches;}
    float IEnglishDimensions.Width() { return widthInches;}
    // ��ʽʵ��IMetricDimensions�еĳ�Ա
    float IMetricDimensions.Length()
    {
        return lengthInches * 2.54f;  //Ӣ��inchת��Ϊ����cm
    }
    float IMetricDimensions.Width()
    {
        return widthInches * 2.54f;  //Ӣ��inchת��Ϊ����cm
    }
    static void Main()
    {   // ��Box��ʵ��box1
        Box box1 = new Box(30.0f, 20.0f);
        //����Ӣ��inchΪ��λ�ģ�IEnglishDimensions��ʵ��
        IEnglishDimensions eDimensions = (IEnglishDimensions)box1;
        // ���Թ���cmΪ��λ�ģ�IMetricDimensions��ʵ��
        IMetricDimensions mDimensions = (IMetricDimensions)box1;
        // ��ӡ��Ӣ��inchΪ��λ�ĳ�����Ϣ
        Console.WriteLine("Length(in): {0}", eDimensions.Length());
        Console.WriteLine("Width (in): {0}", eDimensions.Width());
        //��ӡ�Թ���cmΪ��λ�ĳ�����Ϣ
        Console.WriteLine("Length(cm): {0}", mDimensions.Length());
        Console.WriteLine("Width (cm): {0}", mDimensions.Width()); Console.ReadKey();
    }
  }
}
