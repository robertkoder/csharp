namespace csharp
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Percentage(double value, double total)
        {
            return (value / total) * 100;
        }
    }
}
