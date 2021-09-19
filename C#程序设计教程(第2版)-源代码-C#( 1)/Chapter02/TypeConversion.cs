namespace CSharpBook.Chapter02
{
   class TypeConversion
   {
      static void Main()
      {
        sbyte sbyte1 = 123;           //��ʽ����ת����int �� sbyte
        sbyte sbyte2 = (sbyte)123;     //��ʽ����ת����int �� sbyte
        byte byte1 = 123;            //��ʽ����ת����int �� byte
        byte byte2 = (byte)123;       //��ʽ����ת����int �� byte
        short short1 = 123;           //��ʽ����ת����int �� short
        short short2 = (short)123;      //��ʽ����ת����int �� short
        ushort ushort1 = 123;         //��ʽ����ת����int �� ushort
        ushort ushort2 = (ushort)123;   //��ʽ����ת����int �� ushort
        int int1 = 123;               //OK: 123Ĭ��Ϊint����
        uint uint1 = 123;             //��ʽ����ת����int �� uint
        uint uint2 = 123U;            //ʹ�ú�׺ u �� U ��ʼ�� uint
        uint uint3 = (uint)123;         //��ʽ����ת����int �� uint
        long long1 = 123;            //��ʽ����ת����int �� long
        long long2 = 123L;           //ʹ�ú�׺ l �� L ��ʼ�� long
        long long3 = (long)123;       //��ʽ����ת����int �� long
        ulong ulong1 = 123;          //��ʽ����ת����int �� ulong
        ulong ulong2 = 123UL;       //ʹ�ú�׺ ul �� UL ��ʼ�� ulong
        ulong ulong3 = (ulong)123;    //��ʽ����ת����int �� ulong
        float f1 = 12.3F;             //ʹ�ú�׺ f �� F ��ʼ�� float
        float f2 = (float)123;          //��ʽ����ת����int�� float
        double d1 = 12.3;            //OK: 12.3Ĭ��Ϊdouble�����ͱ���
        double d2 = 12.3D;           //ʹ�ú�׺ d �� D ��ʼ��double�����ͱ���
        decimal de1 = 12.30M;	      //ʹ�ú�׺ m �� M ��ʼ��decimal���ͱ���
        decimal de2 = (decimal)12.30;  //��ʽ����ת����double �� decimal
        double dNumber = 23.15;      //OK: 23.15Ĭ��Ϊdouble�����ͱ���
        int iNumber = System.Convert.ToInt32(dNumber);      //���� 23
        bool bNumber = System.Convert.ToBoolean(dNumber);  //���� True
        string strNumber = System.Convert.ToString(dNumber);  //���� "23.15"
        char chrNumber = System.Convert.ToChar(strNumber[0]);//���� '2'
     }
  }
}
