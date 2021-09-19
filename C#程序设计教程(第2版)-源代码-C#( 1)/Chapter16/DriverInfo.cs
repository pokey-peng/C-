using System; using System.IO;
namespace CSharpBook.Chapter10
{
   class DriverInfoTest
   {  
      static void Main()
      {  
         DriveInfo[] allDrives = DriveInfo.GetDrives();
         foreach (DriveInfo d in allDrives)
         {  
            Console.WriteLine("������ {0}", d.Name); Console.WriteLine("  ����: {0}", d.DriveType);
            if (d.IsReady == true)
           { 
             Console.WriteLine("  ���: {0}", d.VolumeLabel);
             Console.WriteLine("  �ļ�ϵͳ: {0}", d.DriveFormat);
             Console.WriteLine("  ��ǰ�û����ÿռ�: {0, 15}�ֽ�", d.AvailableFreeSpace);
             Console.WriteLine("  ���ÿռ�:         {0, 15}�ֽ�", d.TotalFreeSpace);
             Console.WriteLine("  �����ܴ�С:       {0, 15}�ֽ�", d.TotalSize); Console.ReadLine();
          }
      }
     }
   }	
}
