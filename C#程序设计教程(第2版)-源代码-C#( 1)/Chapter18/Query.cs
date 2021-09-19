using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class QueryCategoriesTest
   {
      static void Main()
      {  // (1)���ӵ����ݿ�
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
                  AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextQuery = "SELECT RegionID, RegionDescription FROM Region";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            // (2)����SqlCommand����
            SqlCommand cmdQuery = new SqlCommand(commandTextQuery, connection);
            // (3)ִ��SqlCommand������ؽ��
            SqlDataReader reader = cmdQuery.ExecuteReader();
            Console.WriteLine("Northwind.MDF���ݿ��Region����������£�");
            Console.WriteLine("�������\t����˵��");
            //(4)ͨ��ѭ���б���ʾ��ѯ�����
            while (reader.Read()){ Console.WriteLine("   {0} \t\t {1}", reader[0], reader[1]); }
            reader.Close();  //�رղ�ѯ�����
         }
       }
   }
}
