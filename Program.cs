bool bandera = true;

do
{
    Console.WriteLine("Ingrese el path:");
    string elPath = @"C:\Users\Alumno\Desktop\tp-09-con diego\tl1-tp9-2025-pr-juan-k\bin\" + Console.ReadLine();

    if (Directory.Exists(elPath))
    {
        Console.WriteLine("La carpeta existe."); 

        string[] carpetas = Directory.GetDirectories(elPath);

        foreach (string carpeta in carpetas)
        {
            Console.WriteLine(Path.GetFileName(carpeta));
            var nombreDelArchivo = Directory.GetDirectories(elPath);

        }

        bandera = false;
    }
    else
    {
        Console.WriteLine("La carpeta no existe, Ingrese una valida:");
    }

} while (bandera); 





//      ..//casita/




