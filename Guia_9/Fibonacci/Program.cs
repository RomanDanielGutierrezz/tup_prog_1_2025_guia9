namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contTerminos = 1;
            int valorAct = 0;
            int valorAnt = 1;
            int valorSiguiente = 0;
            Console.WriteLine("Ingrese cantidad de terminos");
            int terminos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= terminos; i++)
            {
                if (contTerminos<=1)
                {
                    valorAct = 1;
                    valorAnt = 0;
                    Console.WriteLine(valorAnt);
                    Console.WriteLine(valorAct);
                }
                else
                {
                    valorSiguiente = valorAct + valorAnt;
                    valorAnt = valorAct;
                    valorAct = valorSiguiente;
                    Console.WriteLine(valorSiguiente);
                }
                contTerminos++;
            }
        }
    }
}