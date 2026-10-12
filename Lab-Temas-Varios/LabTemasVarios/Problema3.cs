// Problema 3: Metodos sobrecargados
static class Problema3
{
    public static void Ejecutar()
    {
        Console.WriteLine("PROBLEMA 3 - METODOS SOBRECARGADOS");
        Console.WriteLine();

        Calculadora calc = new Calculadora();
        int[] lista = { 10, 20, 30, 40 };

        Console.WriteLine("Suma de 2 enteros: " + calc.Sumar(5, 3));
        Console.WriteLine("Suma de 3 enteros: " + calc.Sumar(5, 3, 2));
        Console.WriteLine("Suma de 2 decimales: " + calc.Sumar(2.5, 1.5));
        Console.WriteLine("Suma de un arreglo: " + calc.Sumar(lista));
    }
}
