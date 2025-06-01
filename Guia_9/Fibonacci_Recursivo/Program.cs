namespace Fibonacci_Recursivo
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de terminos");
            int terminos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < terminos; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}