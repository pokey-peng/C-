using System;
namespace CSharpBook.Chapter08
{  
   public interface IBankAccount    //�����˻�
   { 
     void PayIn(decimal amount);    //���
     bool Withdraw(decimal amount); //ȡ��������Ƿ�ɹ�
     decimal Balance { get; }        //���
   }
   public interface ITransferBankAccount : IBankAccount //ת�������˻�
  {  bool TransferTo(IBankAccount destination, decimal amount);  }
   public class CurrentAccount : ITransferBankAccount   //��ǰ�˻�
  {  
     private decimal balance;              //���
      public void PayIn(decimal amount) { balance += amount; }//���
     public bool Withdraw(decimal amount)  //ȡ��
      {  // �˻����㹻����ȡ��������Ƿ�ɹ�
         if (balance >= amount) { balance -= amount;  return true; }
         Console.WriteLine("���㣬ȡ��ʧ�ܣ�");  return false;
      }
      public decimal Balance { get { return balance; }}  //�������
      public bool TransferTo(IBankAccount destination, decimal amount)//����ת��
      {
         bool result; 
         if ((result = Withdraw(amount)) == true) destination.PayIn(amount);
         return result;
      }
      public override string ToString()  //�������е�ǰ�˻��е����
      {  
         return String.Format("Current Bank Account: Balance= {0,6:C}", balance);
      }
  }
  class TestClass
  {  
     static void Main()
     {  IBankAccount account1 = new CurrentAccount();       //�˻�1
        ITransferBankAccount account2 = new CurrentAccount(); //�˻�2
        account1.PayIn(200);              //�˻�1���200Ԫ
        account2.PayIn(500);              //�˻�2���500Ԫ
        account2.TransferTo(account1, 100); //�˻�2ת��100Ԫ���˻�1
        Console.WriteLine("account1's "+account1.ToString()); //��ʾ�˻�1���
        Console.WriteLine("account2's "+account2.ToString()); //��ʾ�˻�2���
        Console.ReadKey();
    }
  }
}
