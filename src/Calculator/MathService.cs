namespace Calculator;

/// <summary>
/// A simple math service to demonstrate CI/CD pipelines.
/// Workshop participants can add new methods here and write tests for them.
/// </summary>
public class MathService
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return (double)a / b;
    }

    public bool IsEven(int number) => number % 2 == 0;

    public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers.", nameof(n));

        if (n == 0 || n == 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;

        return result;
    }
}