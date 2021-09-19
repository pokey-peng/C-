using System;using System.Text;
namespace CSharpBook.Chapter15
{
   class ConvertExampleClass
   {
      static void Main()
      {
         string unicodeString = "���ַ�������unicode�ַ�Pi(\u03a0)";
         // ����2����ͬ�ı��룺ASCII��UNICODE
         Encoding ascii = Encoding.ASCII; Encoding unicode = Encoding.Unicode;
         byte[] unicodeBytes = unicode.GetBytes(unicodeString); //��stringת��Ϊbyte[]
         byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes); //ת������
         //��byte[]ת��Ϊchar[]����ת��Ϊstring
         //��ʾGetCharCount/GetCharsת��������ʹ�ã�ע�����е�ϸ΢���
         char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
         ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
         string asciiString = new string(asciiChars);
         //��ʾ�ַ���ת��֮ǰ��ת��֮�������
         Console.WriteLine("ԭʼstring��Unicode����{0}", unicodeString);
         Console.WriteLine("ת�����string��Ascii����{0}", asciiString);
      }
   }
}
