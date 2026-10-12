// Clase con metodos sobrecargados (mismo nombre, distintos parametros)
class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public int Sumar(int[] numeros)
    {
        int total = 0;
        foreach (int n in numeros)
        {
            total += n;
        }
        return total;
    }
}
