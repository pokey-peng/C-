//���룺csc /r:System.DLL /r:System.Windows.Forms.DLL /r:System.Drawing.DLL EventHandle.cs
using System;using System.ComponentModel;
using System.Windows.Forms;using System.Drawing;
namespace CSharpBook.Chapter09
{
  public class MyForm : Form //����
  {
   private TextBox box;       //�ı���
   private Button button;      //��ť
   public MyForm() : base()  
   {  
      box = new TextBox();                    //�½��ı���
      box.BackColor = System.Drawing.Color.Cyan;//���ñ���ɫΪ����ɫ
      box.Size = new Size(100,100);             //�����ı����С
      box.Location = new Point(50,50);          //�����ı���λ��
      box.Text = "Hello";                     //�����ı����ı�����
      button = new Button();                  //�½���ť
      button.Location = new Point(50,100);      //���ð�ťλ��
      button.Text = "Click Me";               //���ð�ť�ı�����
      //ͨ��+=��ಥ�¼�ί��ʵ����װ�ĵ����б�������¼�������
      button.Click += new EventHandler(this.Button_Click);//��ť�����¼�
      Controls.Add(box);  Controls.Add(button); 
   }
   private void Button_Click(object sender, EventArgs e) // ������ť�����¼�������
   {
      box.BackColor = System.Drawing.Color.Green;  // �ı��򱳾�ɫ��Ϊ��ɫ
   }
   [STAThreadAttribute]
   public static void Main(string[] args) 
   {
      Application.Run(new MyForm());
   }
  }
}
