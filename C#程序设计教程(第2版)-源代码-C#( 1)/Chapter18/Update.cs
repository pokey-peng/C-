using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class UpdateRegionTest
   {
      static void Main()
      {  //(1)���ӵ����ݿ�
         String connString = @"Data Source= (LocalDB)\v11.0;Initial Catalog=Northwind;
               AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextUpdate = 
               "Update Region Set RegionDescription = @name WHERE RegionID = @id";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            //(2)����SqlCommand����
            SqlCommand cmdUpdate = new SqlCommand(commandTextUpdate, connection);
            cmdUpdate.Parameters.AddWithValue("@id", 5);
            cmdUpdate.Parameters.AddWithValue("@name", "ECNU, Shanghai");
            //(3)ִ��SqlCommand��������
            int result = cmdUpdate.ExecuteNonQuery();
            if (result == 1) { Console.WriteLine("���¼�¼�����ɹ�."); }
            else { Console.WriteLine("���¼�¼����ʧ��."); }
         }
      }
   }
}
