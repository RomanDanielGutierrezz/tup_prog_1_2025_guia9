namespace Numeros_Primos
{
    internal class Program
    {
        static bool Primo(int n, int divisor = 2)
        {
            if (n % divisor == 0)
                return false;
            if (divisor * divisor > n)
                return true;
            if (n < 2) 
                return false;
            return Primo(n, divisor + 1);
        }
        static void Main(string[] args)
        {
            int n = 0; int m = 0;
            Console.WriteLine("Indique el numeor inical");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique el numero final");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                if (Primo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
