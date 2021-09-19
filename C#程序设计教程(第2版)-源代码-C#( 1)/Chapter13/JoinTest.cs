using System; using System.Linq; using System.Collections.Generic;
namespace CSharpBook.Chapter13
{
    public class Category //���
    {
        public string ID, Name; //����š��������
        public static List<Category> GetCategoryList()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category { ID = "1", Name = "����" });
            list.Add(new Category { ID = "2", Name = "ˮ��" });
            list.Add(new Category { ID = "3", Name = "�߲�" });
            return (list);
        }
    }
    public class Product //��Ʒ
    {
        public string ID, Name, categoryID;//��Ʒ��š���Ʒ���ơ������
        public int num; //��Ʒ����
        public static List<Product> GetProductList()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { ID = "1", Name = "����", num = 10, categoryID = "1" });
            list.Add(new Product { ID = "2", Name = "��֭", num = 20, categoryID = "1" });
            list.Add(new Product { ID = "3", Name = "ƻ��", num = 11, categoryID = "2" });
            list.Add(new Product { ID = "4", Name = "�㽶", num = 22, categoryID = "2" });
            list.Add(new Product { ID = "5", Name = "����", num = 33, categoryID = "2" });
            return (list);
        }
    }
    public class JoinTest
    {
        public static void Main()
        {
            List<Category> categories = Category.GetCategoryList();
            List<Product> products = Product.GetProductList();
            var q11 = from c in categories
                      join p in products on c.ID equals p.categoryID
                      select new { CategoryName = c.Name, ProductID = p.ID, ProductName = p.Name };
            foreach (var item in q11) Console.WriteLine(item);
            var q12 = categories.Join(products, c => c.ID, p => p.categoryID,
                      (c, p) => new { CategoryName = c.Name, ProductID = p.ID, ProductName = p.Name });
            foreach (var item in q12) Console.WriteLine(item);
            var q21 = from c in categories
                      join p in products on c.ID equals p.categoryID into ps
                      select new { CategoryName = c.Name, Nums = ps.Sum(p => p.num) };
            foreach (var item in q21) Console.WriteLine(item);
            var q22 = categories.GroupJoin(products, c => c.ID, p => p.categoryID,
                                    (c, ps) => new { CategoryName = c.Name, Nums = ps.Sum(p => p.num) });
            foreach (var item in q22) Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
