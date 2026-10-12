using Microsoft.Data.Sqlite;

// Base de datos SQLite en memoria (no hay que instalar nada)
static class BaseDatos
{
    public static SqliteConnection Crear()
    {
        SqliteConnection conexion = new SqliteConnection("Data Source=:memory:");
        conexion.Open();

        SqliteCommand cmd = conexion.CreateCommand();
        cmd.CommandText = @"
            CREATE TABLE Estudiantes (Id INTEGER PRIMARY KEY, Nombre TEXT, Carrera TEXT, Edad INTEGER);
            INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES ('Ana', 'Software', 20);
            INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES ('Luis', 'Sistemas', 22);
            INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES ('Maria', 'Software', 19);
            INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES ('Carlos', 'Civil', 23);
            INSERT INTO Estudiantes (Nombre, Carrera, Edad) VALUES ('Sofia', 'Sistemas', 21);";
        cmd.ExecuteNonQuery();

        return conexion;
    }

    public static void MostrarEstudiantes(SqliteConnection conexion)
    {
        SqliteCommand cmd = conexion.CreateCommand();
        cmd.CommandText = "SELECT * FROM Estudiantes";

        using (SqliteDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetInt32(3));
            }
        }
    }
}
