using static System.Console;

WriteLine(Calculator.AddValues(2, 3));          // ใช้ int
WriteLine(Calculator.AddValuesFloat(2.0f, 3.0f));    // ใช้ float
WriteLine(Calculator.AddValuesLong(2L, 3L));        // ใช้ long

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    public static long AddValuesLong(long c, long d)
    {
        WriteLine("Calculated by method: public static long AddValues(long c, long d)");
        return c + d;
    }

    public static float AddValuesFloat(float f, float g)
    {
        WriteLine("Calculated by method: public static float AddValues(float f, float g)");
        return f + g;
    }

    public static long AddValuesLongForLong(long h, long i)
    {
        WriteLine("Calculated by method: public static long AddValues(long h, long i)");
        return h + i;
    }
}
