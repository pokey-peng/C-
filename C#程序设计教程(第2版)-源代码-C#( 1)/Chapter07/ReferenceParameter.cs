using System;
namespace CSharpBook.Chapter07
{
  class Test 
  { 
    static void Swap(ref int x, ref int y)   // ���������������βΣ�
    {
        int temp = x; x = y; y = temp; 
    } 
    static void Main() 
    {   
        int i = 1, j = 2; 
        Console.WriteLine("Before swap, i = {0}, j = {1}", i, j);
        Swap(ref i, ref j); 
        Console.WriteLine("After swap, i = {0}, j = {1}", i, j); Console.ReadLine();
    } 
  }
}
