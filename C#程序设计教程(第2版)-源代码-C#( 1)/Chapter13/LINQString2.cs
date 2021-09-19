using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class CountWords
  {
    static void Main()
    {
        string text = @"Encryption is the translation of data into a secret code." +
          @"Encryption is the most effective way to achieve data security." +
          @"To read an encrypted file, you must have access to a secret key" +
          @"or password that enables you to decrypt it.Unencrypted data " +
          @"is called plain text (or plaintext); encrypted data is " +
          @"referred to as cipher text (or ciphertext)." ;
        string[] wordsToMatch = { "Encryption", "data" };//Ҫ��ѯ�ĵ����б�
        //���ַ���ת��Ϊ�ַ��������ӣ�����
        string[] sentences = text.Split(new char[] { '.', '?', '!' });
        //������ѯ����ѯ���а���"Encryption"��"data"��Ԫ��
        var sentenceQuery = from sentence in sentences
                    let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' })
                    where w.Distinct().Intersect(wordsToMatch).Count() 
                                   == wordsToMatch.Count()
                    select sentence;
        Console.WriteLine("���а���Encryption��data�ľ����У�");
        int i = 1;
        foreach (string str in sentenceQuery)//ִ�в�ѯ����ѭ����ʾ��ѯ���
        {
            Console.WriteLine("({0})��{1}",i++,str);
        }
        Console.ReadKey();
    }
  }
}
