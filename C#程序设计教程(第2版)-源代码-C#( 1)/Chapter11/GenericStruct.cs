using System;
namespace CSharpBook.Chapter11
{
    struct Point<T>
    {
        public T x;  public T y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> pi = new Point<int>();  //����Ϊint��Point
            pi.x = 2; pi.y = 2;
            Console.WriteLine("(" + pi.x.ToString() + ", " + pi.y.ToString() + ")");
            Point<double> pd = new Point<double>(); //����Ϊdouble��Point
            pd.x = 3.3; pd.y = 3.3;
            Console.WriteLine("(" + pd.x.ToString() + ", " + pd.y.ToString() + ")");
            Console.ReadKey();
        }
    }
}
