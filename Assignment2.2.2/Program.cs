
// Test methods
Console.WriteLine("Addition of two integers: " + Maths.Add(5, 10));
Console.WriteLine("Addition of three decimals: " + Maths.Add(5.5m, 10.2m, 3.3m));
Console.WriteLine("Multiplication of two floats: " + Maths.Multiply(2.5f, 4.0f));
Console.WriteLine("Multiplication of three floats: " + Maths.Multiply(2.0f, 3.0f, 4.0f));


class Maths
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }

    public static float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }

    public static float Multiply(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }

}

