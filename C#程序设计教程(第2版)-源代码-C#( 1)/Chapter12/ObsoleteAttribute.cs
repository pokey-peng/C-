using System; using System.Diagnostics;
namespace CSharpBook.Chapter12
{
  [System.Obsolete("use class B")]
  class A
  {
    public void Method() { }
  }
  class B
  {
    [System.Obsolete("use NewMethod", true)]
    public void OldMethod() { }
    public void NewMethod() { }
  }
  class Test
  {
    public static void Main()
    {//����2��������Ϣ����CSharpBook.Chapter12.A���ѹ�ʱ��use class B����
        A a = new A(); B b = new B(); b.NewMethod();
     //����������Ϣ��CSharpBook.Chapter12.B.OldMethod()�ѹ�ʱuse NewMethod����ֹ����
        b.OldMethod();
    }
  }
}
