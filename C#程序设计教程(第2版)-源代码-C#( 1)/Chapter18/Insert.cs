using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class InsertRegionTest
   {
      static void Main()
      {  //(1)���ӵ����ݿ�
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
               AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextInsert = 
                "INSERT INTO Region(RegionID,RegionDescription) VALUES(@id,@name)";
         using (SqlConnection connection = new SqlConnection(connString))
         {  connection.Open();
            //(2)����SqlCommand����
            SqlCommand cmdInsert = new SqlCommand(commandTextInsert, connection);
            cmdInsert.Parameters.AddWithValue("@id", 5);
            cmdInsert.Parameters.AddWithValue("@name", "ECNU");
            //(3)ִ��SqlCommand��������
            int result = cmdInsert.ExecuteNonQuery();
            if (result == 1) { Console.WriteLine("�����¼�����ɹ�."); }
            else { Console.WriteLine("�����¼����ʧ��."); }
         }
      }
   }
}
