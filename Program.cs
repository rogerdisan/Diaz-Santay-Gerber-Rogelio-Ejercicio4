Console.WriteLine("=== Clasificador de Incidentes de Seguridad ===");
Console.WriteLine("Tipo de incidente:");
Console.WriteLine("1. Malware");
Console.WriteLine("2. Phishing");
Console.WriteLine("3. Acceso no autorizado");
Console.WriteLine("4. Fuga de informacion");
Console.Write("Seleccione: ");

int incidente = int.Parse(Console.ReadLine());

Console.WriteLine("Activo afectado:");
Console.WriteLine("1. PC");
Console.WriteLine("2. Servidor");
Console.WriteLine("3. Base de datos");
Console.WriteLine("4. Red");
Console.Write("Seleccione: ");

int activo = int.Parse(Console.ReadLine());

Console.WriteLine("Datos comprometidos:");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Internos");
Console.WriteLine("3. Personales");
Console.WriteLine("4. Financieros");
Console.Write("Seleccione: ");
int datos = int.Parse(Console.ReadLine());

Console.Write("Persistencia detectada (S/N): ");
char persistencia = char.Parse(Console.ReadLine().ToUpper());

Console.Write("Numero de usuarios afectados: ");
int usuarios = int.Parse(Console.ReadLine());
