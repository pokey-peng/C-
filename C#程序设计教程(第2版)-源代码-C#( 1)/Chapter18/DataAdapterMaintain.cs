using System; using System.IO; using System.Data; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class MaintainCategoriesByDataSetTest
   {
      static void Main()
      {  //���ӵ����ݿ�
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
              AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String selectCommandText = "SELECT RegionID, RegionDescription FROM Region";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            //ɾ�������ݣ�������ڵĻ���
            SqlCommand cmdDelete =
               new SqlCommand("DELETE FROM Region WHERE RegionID > 4", connection);
            cmdDelete.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, connection);
            //ʹ��CommandBuilder�Զ�����DataAdapter��InsertCommand��
            //UpdateCommand��DeleteCommand����
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();  //����DataSet
            adapter.Fill(dataSet, "Region");   //��DataAdapter���DataSet
            //����DataTable��������
            DataColumn[] keys = new DataColumn[1];
            keys[0] = dataSet.Tables["Region"].Columns["RegionID"];
            dataSet.Tables["Region"].PrimaryKey = keys;
            //�����ʹ���DataSet�������Ӽ�¼
            DataRow newRow1 = dataSet.Tables["Region"].NewRow();
            newRow1["RegionID"] = 5;  newRow1["RegionDescription"] = "Shanghai";
            dataSet.Tables["Region"].Rows.Add(newRow1);
            DataRow newRow2 = dataSet.Tables["Region"].NewRow();
            newRow2["RegionID"] = 6;  newRow2["RegionDescription"] = "ECNU";
            dataSet.Tables["Region"].Rows.Add(newRow2);
            //�����ʹ���DataSet�������¼�¼
            DataRow updateRow = dataSet.Tables["Region"].Rows.Find(5);
            updateRow["RegionDescription"] = "Shanghai, China";
            //�����ʹ���DataSet����ɾ����¼
            DataRow deleteRow = dataSet.Tables["Region"].Rows.Find(6);
            dataSet.Tables["Region"].Rows.Remove(deleteRow);
            adapter.Update(dataSet, "Region"); //����DataAdapter��Update������������Դ
            Console.WriteLine("���ʹ��DataAdapter��DataSetά��Region��");
         }
      }
   }
}
