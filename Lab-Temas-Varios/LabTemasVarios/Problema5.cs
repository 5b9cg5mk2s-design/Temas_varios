// Problema 5: Frecuencias
static class Problema5
{
    public static void Ejecutar()
    {
        Console.WriteLine("PROBLEMA 5 - FRECUENCIAS");
        Console.WriteLine();

        int[] numeros = { 4, 7, 2, 4, 9, 7, 4, 1, 2, 7, 7, 3 };
        Dictionary<int, int> frecuencias = new Dictionary<int, int>();

        foreach (int n in numeros)
        {
            if (frecuencias.ContainsKey(n))
            {
                frecuencias[n]++;
            }
            else
            {
                frecuencias[n] = 1;
            }
        }

        Console.WriteLine("Numeros: " + string.Join(", ", numeros));
        Console.WriteLine();
        Console.WriteLine("Numero\tFrecuencia");

        foreach (var item in frecuencias)
        {
            Console.WriteLine(item.Key + "\t" + item.Value);
        }
    }
}
