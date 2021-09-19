using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class DeleteRegionTest
   {
      static void Main()
      {  //(1)���ӵ����ݿ�
         String connString = @"Data Source= (LocalDB)\v11.0;Initial Catalog=Northwind;
                 AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextDelete = "DELETE FROM Region WHERE RegionID = @id";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            //(2)����SqlCommand����
            SqlCommand cmdDelete = new SqlCommand(commandTextDelete, connection);
            cmdDelete.Parameters.AddWithValue("@id", 5);
            //(3)ִ��SqlCommand��������
            int result = cmdDelete.ExecuteNonQuery();
            if (result == 1) { Console.WriteLine("ɾ����¼�����ɹ�."); }
            else { Console.WriteLine("ɾ����¼����ʧ��."); }
         }
      }
   }
}
