using Microsoft.Data.Sqlite;

// Problema 2: Armar INSERT y UPDATE con cadenas, Inyeccion SQL y Consultas Parametrizadas
static class Problema2
{
    // Forma insegura: se arma el SQL pegando cadenas
    static string ArmarInsert(string nombre, string carrera, int edad)
    {
        return "INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES ('" + nombre + "', '" + carrera + "', " + edad + ")";
    }

    static string ArmarUpdate(int id, string nombre)
    {
        return "UPDATE Estudiantes SET Nombre = '" + nombre + "' WHERE Id = " + id;
    }

    public static void Ejecutar()
    {
        Console.WriteLine("PROBLEMA 2 - CADENAS, INYECCION SQL Y CONSULTAS PARAMETRIZADAS");
        Console.WriteLine();

        SqliteConnection conexion = BaseDatos.Crear();
        SqliteCommand cmd;
        int filas;

        // 1. INSERT con cadenas
        Console.WriteLine("1) INSERT armado con cadenas:");
        cmd = conexion.CreateCommand();
        cmd.CommandText = ArmarInsert("Pedro", "Civil", 24);
        Console.WriteLine(cmd.CommandText);
        filas = cmd.ExecuteNonQuery();
        Console.WriteLine("Filas insertadas: " + filas);
        Console.WriteLine();

        // 2. UPDATE con cadenas
        Console.WriteLine("2) UPDATE armado con cadenas:");
        cmd = conexion.CreateCommand();
        cmd.CommandText = ArmarUpdate(2, "Luisa");
        Console.WriteLine(cmd.CommandText);
        filas = cmd.ExecuteNonQuery();
        Console.WriteLine("Filas actualizadas: " + filas);
        Console.WriteLine();

        // 3. Inyeccion SQL
        string nombreMalicioso = "Hackeado' --";
        Console.WriteLine("3) Inyeccion SQL. El usuario escribe como nombre: " + nombreMalicioso);
        cmd = conexion.CreateCommand();
        cmd.CommandText = ArmarUpdate(1, nombreMalicioso);
        Console.WriteLine(cmd.CommandText);
        filas = cmd.ExecuteNonQuery();
        Console.WriteLine("Filas actualizadas: " + filas + "  <-- se cambiaron todos, el -- anulo el WHERE");
        BaseDatos.MostrarEstudiantes(conexion);
        conexion.Close();
        Console.WriteLine();

        // 4. Lo mismo pero con consulta parametrizada
        conexion = BaseDatos.Crear();
        Console.WriteLine("4) UPDATE con consulta parametrizada:");
        cmd = conexion.CreateCommand();
        cmd.CommandText = "UPDATE Estudiantes SET Nombre = @nombre WHERE Id = @id";
        cmd.Parameters.AddWithValue("@nombre", nombreMalicioso);
        cmd.Parameters.AddWithValue("@id", 1);
        Console.WriteLine(cmd.CommandText);
        filas = cmd.ExecuteNonQuery();
        Console.WriteLine("Filas actualizadas: " + filas + "  <-- solo se cambio el Id 1");
        Console.WriteLine();

        // 5. INSERT con consulta parametrizada
        Console.WriteLine("5) INSERT con consulta parametrizada:");
        cmd = conexion.CreateCommand();
        cmd.CommandText = "INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES (@nombre, @carrera, @edad)";
        cmd.Parameters.AddWithValue("@nombre", "Pedro");
        cmd.Parameters.AddWithValue("@carrera", "Civil");
        cmd.Parameters.AddWithValue("@edad", 24);
        Console.WriteLine(cmd.CommandText);
        filas = cmd.ExecuteNonQuery();
        Console.WriteLine("Filas insertadas: " + filas);
        BaseDatos.MostrarEstudiantes(conexion);

        conexion.Close();
    }
}
