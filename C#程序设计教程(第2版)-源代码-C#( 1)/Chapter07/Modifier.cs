class Person
{
    public const int RETIREMENT_AGE = 65;  //���ʲ�������
    public string name;       //���ʲ�������
    internal string nickName;  //���Զ���Person��ĳ����ڿɷ���
    protected bool isMarried;  //��Person��������������пɷ���
    private int age;          //ֻ��Person���ڿɷ���
    string creditCardNum;    //ʹ��Ĭ�Ϸ������η�private��ֻ��Person���ڿɷ���
    public void Speak()      //���ʲ�������
    {
       System.Console.WriteLine("Hello!");
    }
    private void Method1()      //ֻ��Person���ڿɷ���
    {  //��
      // ��Person�ڵķ����Ա������г�Ա���ɷ��ʣ�����أ�
      //��1��RETIREMENT_AGE�ɷ��ʣ�2��name�ɷ��ʣ�3��nickName�ɷ���
     //��4��isMarried�ɷ��ʣ�5��age�ɷ��ʣ�6��creditCardNum�ɷ��ʣ�7��Speak()�ɷ���
    }
}
class Student : Person
{
    private void Method2()
    {  //��
       // λ��ͬһ�������������Student�ڵķ���������Person��Ա�ķ���Ȩ�����£�
       // public��protected��internal��Ա���ɷ��ʣ�private��Ա���ɷ��ʣ�����أ�
       // ��1��RETIREMENT_AGE�ɷ��ʣ�public����2��name�ɷ��ʣ�public��
       // ��3��nickName�ɷ��ʣ�internal����4��isMarried�ɷ��ʣ�protected��
       // ��5��age���ɷ��ʣ�private����6��creditCardNum���ɷ��ʣ�private��
       // ��7��Speak()�ɷ��ʣ�public����8��Method1()���ɷ��ʣ�private��
    }
}
class Dog
{
    private void Method3()
    {  //��
       // �����ڵķ��������ڵķ���������Person��Ա�ķ���Ȩ�����£�
       // public��internal��Ա���ɷ��ʣ�protected��private��Ա���ɷ��ʣ�����أ�
      //��1��RETIREMENT_AGE�ɷ��ʣ�public����2��name�ɷ��ʣ�public��
      //��3��nickName�ɷ��ʣ�internal����4��isMarried���ɷ��ʣ�protected��
      //��5��age���ɷ��ʣ�private����6��creditCardNum���ɷ��ʣ�private��
      //��7��Speak()�ɷ��ʣ�public����8��Method1()���ɷ��ʣ�private��
   }
}
