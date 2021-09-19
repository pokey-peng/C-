using System; using System.IO;
namespace CSharpBook.Chapter10
{
   class CopyDir
   {  //��ԴĿ¼���Ƶ�Ŀ��Ŀ¼
      static public void CopyDirectory(string srcDir, string dstDir)
      {
         DirectoryInfo src= new DirectoryInfo(srcDir);
         DirectoryInfo dst = new DirectoryInfo(dstDir);
         if (!src.Exists) return; //���ԴĿ¼�����ڣ�����������
         if (!dst.Exists) dst.Create();//���Ŀ��Ŀ¼�����ڣ��򴴽�֮
         FileInfo[] sfs = src.GetFiles();         //��ȡĿ¼�е��ļ�
         for (int i = 0; i < sfs.Length; ++i)       //�ļ�����
             File.Copy(sfs[i].FullName, dst.FullName + "\\" + sfs[i].Name, true);
         DirectoryInfo[] srcDirs = src.GetDirectories();  //��ȡĿ¼��Ϣ
         for (int j = 0; j < srcDirs.Length; ++j)         //Ŀ¼����
             CopyDirectory(srcDirs[j].FullName, dst.FullName + "\\" + srcDirs[j].Name);
      }
      static void Main(string[] args)
      {
         try
         {
            string src = args[0];      //�����в���1��ԴĿ¼��
            string dst = args[1];      //�����в���2��Ŀ��Ŀ¼��
            CopyDirectory(src, dst);  //��ԴĿ¼���Ƶ�Ŀ��Ŀ¼
            Console.WriteLine("\nԴĿ¼{0}���������Ѿ��ɹ����Ƶ�Ŀ��Ŀ¼{1}�У�", src, dst);
         }
         catch (Exception e) { Console.WriteLine("\n����ʧ��: {0}", e.ToString()); }
         finally { }
         Console.ReadLine();
      }
   }
}
