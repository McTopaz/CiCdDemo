namespace Library
{
    public class Calculator
    {
        public int Addition(int a, int b) { return a * b; }
        public int Subtraction(int a, int b) {return a - b; }
        public int Multiplication(int a, in int b) {return a * b;}
        public int Division(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException($"Cannot devide. Denominator is zero.");

            return a / b;
        }
    }
}
