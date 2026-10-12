using Microsoft.Data.Sqlite;

// Problema 1: Consultas SQL (3)
static class Problema1
{
    public static void Ejecutar()
    {
        Console.WriteLine("PROBLEMA 1 - CONSULTAS SQL");
        Console.WriteLine();

        SqliteConnection conexion = BaseDatos.Crear();

        // Consulta 1
        Console.WriteLine("Consulta 1: todos los estudiantes");
        Console.WriteLine("SELECT * FROM Estudiantes");
        BaseDatos.MostrarEstudiantes(conexion);
        Console.WriteLine();

        // Consulta 2
        Console.WriteLine("Consulta 2: estudiantes mayores de 20");
        Console.WriteLine("SELECT Nombre, Edad FROM Estudiantes WHERE Edad > @edad");
        SqliteCommand cmd2 = conexion.CreateCommand();
        cmd2.CommandText = "SELECT Nombre, Edad FROM Estudiantes WHERE Edad > @edad";
        cmd2.Parameters.AddWithValue("@edad", 20);
        using (SqliteDataReader reader = cmd2.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) + " - " + reader.GetInt32(1));
            }
        }
        Console.WriteLine();

        // Consulta 3
        Console.WriteLine("Consulta 3: cantidad de estudiantes por carrera");
        Console.WriteLine("SELECT Carrera, COUNT(*) FROM Estudiantes GROUP BY Carrera");
        SqliteCommand cmd3 = conexion.CreateCommand();
        cmd3.CommandText = "SELECT Carrera, COUNT(*) FROM Estudiantes GROUP BY Carrera";
        using (SqliteDataReader reader = cmd3.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) + " - " + reader.GetInt32(1));
            }
        }

        conexion.Close();
    }
}
