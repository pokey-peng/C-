public class ExceptionThrowByCLR
{
    public static void Main()
    {
        int i1 = 1, i2 = 0, i3;
        i3 = i1 / i2;      //CLR�Զ��׳��쳣System.DivideByZeroException
    }
}
