string opcion = "";

while (opcion != "0")
{
    Console.Clear();
    Console.WriteLine("==========================================================");
    Console.WriteLine("             UNIVERSIDAD TECNOLÓGICA DE PANAMÁ            ");
    Console.WriteLine("           FACULTAD DE INGENIERÍA EN SISTEMAS            ");
    Console.WriteLine("      MÓDULO IV: ACCESO A BASE DE DATOS Y TEMAS VARIOS    ");
    Console.WriteLine("             Johandry González 20-14-5043      ");
    Console.WriteLine("==========================================================\n");
    Console.WriteLine();
    Console.WriteLine("1. Problema 1");
    Console.WriteLine("2. Problema 2");
    Console.WriteLine("3. Problema 3");
    Console.WriteLine("4. Problema 4");
    Console.WriteLine("5. Problema 5");
    Console.WriteLine("0. Salir");
    Console.Write("Opcion: ");
    opcion = Console.ReadLine();

    Console.Clear();

    switch (opcion)
    {
        case "1": Problema1.Ejecutar(); break;
        case "2": Problema2.Ejecutar(); break;
        case "3": Problema3.Ejecutar(); break;
        case "4": Problema4.Ejecutar(); break;
        case "5": Problema5.Ejecutar(); break;
        case "0": continue;
        default: Console.WriteLine("Opcion no valida"); break;
    }

    Console.WriteLine();
    Console.Write("Presione Enter para volver al menu...");
    Console.ReadLine();
}
