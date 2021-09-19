using System; using System.IO; using System.Data.SqlClient; using System.Data;
namespace CSharpBook.Chapter18
{
   class QueryByStoredProcedureTest
   {
      static void Main()
      {  // ���ӵ����ݿ�
         String connString = @"Data Source= (LocalDB)\v11.0;Initial Catalog=Northwind;
                  AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         using (SqlConnection connection = new SqlConnection(connString))
         {  connection.Open();
            //����SqlCommand����
            SqlCommand cmdQuery = new SqlCommand("Ten Most Expensive Products", connection);
            cmdQuery.CommandType = CommandType.StoredProcedure;
            //ִ��SqlCommand������ؽ��
            SqlDataReader reader = cmdQuery.ExecuteReader();
            Console.WriteLine("Products��������10����Ʒ����Ϣ��");
            Console.WriteLine("��Ʒ����\t\t\t����");
            while (reader.Read())//ͨ��ѭ���б���ʾ��ѯ�����
              { Console.WriteLine(" {0}\t{1}",reader[0].ToString().PadRight(30), reader[1]); }
            reader.Close();//�رղ�ѯ�����
         }
      }
   }
}
