using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class CountWords
  {
    static void Main()
    {
        string text = @"Encryption is the translation of data into a secret code." +
          @" Encryption is the most effective way to achieve data security." +
          @" To read an encrypted file, you must have access to a secret key" +
          @" or password that enables you to decrypt it.Unencrypted data " +
          @" is called plain text (or plaintext); encrypted data is " +
          @" referred to as cipher text (or ciphertext)." ; 
        string searchTerm = "data";
        //���ַ���ת��Ϊ�ַ��������ʣ�����
        string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //������ѯ����ѯ����ƥ��"data" (���۴�Сд)��Ԫ�� 
        var matchQuery = from word in source
                       where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                       select word;
        int wordCount = matchQuery.Count();  //ͳ��Ԫ�صĸ���
        Console.WriteLine("ָ����{0}������{1}��", searchTerm, wordCount);
        Console.ReadKey();
    }
  }
}
