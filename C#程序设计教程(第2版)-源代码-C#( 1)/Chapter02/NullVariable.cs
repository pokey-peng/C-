using System;
namespace CSharpBook.Chapter02
{
  class NullVariable
  {
     static void Main()
     {
        int? num = null;
        if (num.HasValue == true) { Console.WriteLine("num = " + num.Value); }
        else { Console.WriteLine("num = Null");}
        int y = num.GetValueOrDefault();   // y����Ϊzero
        // ���num.HasValueΪfalse����num.Value���׳�InvalidOperationException�쳣
        try { y = num.Value;}
        catch (System.InvalidOperationException e) { Console.WriteLine(e.Message);}
        Console.ReadKey();
    }
  }
}
