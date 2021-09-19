using System;using System.Threading;
namespace CSharpBook.Chapter15
{ 
  public class RandomObjectDemo
  {  //���ض�������������������
     static void RunIntNDoubleRandoms( Random randObj )
    {  //����6���������
        for( int j = 0; j < 6; j++ ) Console.Write( " {0,10} ", randObj.Next( ) );
        Console.WriteLine( );
        //����6�����˫������.
        for( int j = 0; j < 6; j++ ) Console.Write( " {0:F8} ", randObj.NextDouble( ) );
        Console.WriteLine( );
    }
    //ʹ���ض������Ӵ����������
    static void FixedSeedRandoms( int seed )
    {
        Console.WriteLine("\nʹ���ض������� seed = {0} �����������", seed );
        Random fixRand = new Random( seed );
        RunIntNDoubleRandoms( fixRand );
    }
    //ʹ�ö�ʱ�����ɵ����Ӵ����������
    static void AutoSeedRandoms( )
    {  //�ȴ�������ʱ����ʱ
        Thread.Sleep( 1 );
        Console.WriteLine( "\nʹ���Զ���ʱ�����ɵ����Ӵ����������");
        Random autoRand = new Random( ); RunIntNDoubleRandoms( autoRand );
    }
    static void Main( )
    {	
        Console.WriteLine("Random���캯����Random.NextDouble( )����ʾ�������");
        Console.WriteLine("�����������Ȼ�����ɺ���ʾ6��������˫������.");
        FixedSeedRandoms(123); FixedSeedRandoms(123); FixedSeedRandoms(456);
        AutoSeedRandoms( ); AutoSeedRandoms( ); Console.ReadLine();
    }
  }
}
