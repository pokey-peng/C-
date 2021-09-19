using System; 
namespace CSharpBook.Chapter07
{
  class Test 
  { 
    static void SplitPath(string path, out string dir, out string name) 
    {   // ȡ�ļ����ڵ�Ŀ¼�Լ��ļ�����
        int i = path.Length; 
        while (i > 0) 
        { 
            char ch = path[i-1]; 
            if (ch == '\\' || ch == '/' || ch == ':') break; 
            i--; 
        } 
        dir = path.Substring(0, i); name = path.Substring(i); //Ŀ¼���ļ�
    } 
    static void Main() 
    { 
        string dir, name; 
        SplitPath("c:\\Windows\\System\\hello.txt", out dir, out name); 
        Console.WriteLine("Ŀ¼ = {0}���ļ��� = {1}",dir, name); 
        Console.ReadLine();
    } 
  }
}
