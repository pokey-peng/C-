using System; using System.IO; using System.Data; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class QueryRegionByDataSetTest
   {
      static void Main()
      {  //(1)���ӵ����ݿ�
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
              AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String selectCommandText = "SELECT RegionID, RegionDescription FROM Region";
         using (SqlConnection connection = new SqlConnection(connString))
         {  //(2)����DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, connection);
            connection.Open();
            DataSet dataSet = new DataSet();//����DataSet
            //(3)��DataAdapter���DataSet
            adapter.Fill(dataSet, "Region");
            Console.WriteLine("Northwind���ݿ��Region����������£�");
            Console.WriteLine("������� \t ����˵�� ");
            //(4)�����ʹ���DataSet
            foreach (DataRow row in dataSet.Tables["Region"].Rows)
             { Console.WriteLine("  {0} \t\t {1}", row["RegionID"], row["RegionDescription"]);}
         }
      }
   }
}
