using System;
namespace CSharpBook.Chapter07
{
    partial class Customer
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        partial void OnNameChanging(string newName);  //�����ֲ���������
        partial void OnNameChanged();                //�����ֲ���������
    }
    partial class Customer
    {
        partial void OnNameChanging(string newName)  //�����ֲ�����ʵ��
        {
            Console.WriteLine("Changing " + name + " to " + newName);
        }
        partial void OnNameChanged()               //�����ֲ�����ʵ��
        {
            Console.WriteLine("Changed to " + name);
        }
    }
}
