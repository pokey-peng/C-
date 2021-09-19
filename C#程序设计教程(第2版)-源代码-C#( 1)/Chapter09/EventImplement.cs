using System;
using System.Collections;
namespace CSharpBook.Chapter09
{ //����1�������ṩ�¼����ݵ���
  public class NameListEventArgs : EventArgs
  {
    public string Name { get; set; }
    public int Count { get; set; }
    public NameListEventArgs(string name, int count)
    {
        Name = name;  Count = count;
    }
  }
  //����2�������¼�����ί��
  public delegate void NameListEventHandler(object source, NameListEventArgs args);
  //����3�����������¼����ࣨ�¼������ࣩ
  public class NameList
  {
    ArrayList list;
    //����4�����¼��������У������¼�
    public event NameListEventHandler nameListEvent;
    public NameList()
    {
        list = new ArrayList();
    }
    public void Add(string Name)
    {
        list.Add(Name);
        //����5�����¼��������У�ʵ�ֲ����¼��Ĵ���
        if (nameListEvent != null)
        {
            nameListEvent(this, new NameListEventArgs(Name, list.Count));
        }
    }
  }
  //����6�����������¼����ࣨ�¼������ࣩ
  public class EventDemo
  {
    //����7�����¼��������У������¼�������
    public static void Method1(object source, NameListEventArgs args)
    {
        Console.WriteLine("�б�����������Ŀ��{0}", args.Name);
    }
     public static void Method2(object source, NameListEventArgs args)
    {
        Console.WriteLine("�б��е���Ŀ����{0}", args.Count);
    }
    public static void Main()
    {
        NameList nl = new NameList();
        //����8�����¼��������У����Ļ�ȡ���¼�
        nl.nameListEvent += new NameListEventHandler(EventDemo.Method1);
        nl.nameListEvent += new NameListEventHandler(EventDemo.Method2);
        nl.Add("����"); nl.Add("����"); nl.Add("����"); Console.ReadLine();
    }
  }
}
