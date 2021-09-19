using System;
namespace CSharpBook.Chapter07
{
  class TempRecord
  { // �¶�����
    private float[] temps = new float[5] { 20.1F, 20.2F, 21.5F, 26.9F, 26.8F};
    public int Length                //����
    {
        get { return temps.Length; }   //�������鳤��
    }
    public float this[int index]        //������
    {
        get { return temps[index]; }   //����ָ����������Ӧ������Ԫ��
        set { temps[index] = value; }  //����ָ����������Ӧ������Ԫ�ص�ֵ
    }
  }
  class MainClass
  {
    static void Main()
    {
        TempRecord tempRecord = new TempRecord();
        tempRecord[3] = 26.3F; tempRecord[4] = 62.1F;  //����������
        //����¶������Ԫ�ص�ֵ
        for (int i = 0; i < tempRecord.Length; i++) Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
        Console.ReadLine();
    }
  }
}
