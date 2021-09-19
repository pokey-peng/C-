using System;
namespace CSharpBook.Chapter09
{  //�����¼�����ί��
    public delegate void SampleEventHandler(object sender, EventArgs e);
    public class Publisher 
    {
        public event SampleEventHandler SampleEvent; //�����¼�
        protected virtual void RaiseSampleEvent()     //�����¼�
        {  //������Ҫ������Ϣ��������ֱ��ʹ��EventArgs����
            SampleEvent(this, new EventArgs());    //�����¼�
        }
    }
}
