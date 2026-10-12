// Problema 4: Factorial con recursividad
static class Problema4
{
    static long Factorial(int n)
    {
        if (n <= 1)   // caso base
        {
            return 1;
        }
        return n * Factorial(n - 1);   // se llama a si misma
    }

    public static void Ejecutar()
    {
        Console.WriteLine("PROBLEMA 4 - FACTORIAL RECURSIVO");
        Console.WriteLine();

        Console.Write("Ingrese un numero del 0 al 20: ");
        int n;

        // mas de 20 no cabe en un long
        if (int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 20)
        {
            Console.WriteLine(n + "! = " + Factorial(n));
        }
        else
        {
            Console.WriteLine("Numero no valido");
        }
    }
}
