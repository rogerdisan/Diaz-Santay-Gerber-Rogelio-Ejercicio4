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

if (incidente < 1 || incidente > 4)
{
    Console.WriteLine("Tipo de incidente no valido");
    return;
}
if (activo < 1 || activo > 4)
{
    Console.WriteLine("Activo no valido");
    return;
}
if (datos < 1 || datos > 4)
{
    Console.WriteLine("Tipo de datos no valido");
    return;
}
if (usuarios < 0)
{
    Console.WriteLine("Numero de usuarios no valido");
    return;
}
string severidad = "";
string respuesta = "";

switch (incidente)
{
    case 1: // Malware
        switch (activo)
        {
            case 2: // Servidor
                if (persistencia == 'S')
                {
                    severidad = "Critica";
                    respuesta = "Aislar servidor inmediatamente - Analisis forense completo";
                }
                else
                {
                    severidad = "Alta";
                    respuesta = "Limpieza de malware - Reinstalacion del sistema";
                }
                break;
            case 3: 
                if (datos >= 3)
                {
                    severidad = "Critica";
                    respuesta = "Cortar acceso - Auditoria de datos - Notificar autoridades";
                }
                else
                {
                    severidad = "Alta";
                    respuesta = "Escaneo completo - Restaurar desde backup";
                }
                break;
            default: 
                if (datos >= 3)
                {
                    severidad = "Alta";
                    respuesta = "Limpieza de equipos - Revision de datos comprometidos";
                }
                else
                {
                    severidad = "Media";
                    respuesta = "Limpieza de equipos - Capacitacion al usuario";
                }
                break;
        }
        break;

    case 2: // Phishing
        if (datos >= 4) 
        {
            severidad = "Critica";
            respuesta = "Bloquear cuentas - Notificar banco - Cambiar credenciales";
        }
        else if (datos >= 3) 
        {
            severidad = "Alta";
            respuesta = "Cambiar credenciales - Alertar a usuarios afectados";
        }
        else
        {
            severidad = "Media";
            respuesta = "Bloquear cuenta comprometida - Enviar alerta";
        }
        break;

    case 3: // Acceso no autorizado
        if (datos >= 4)
        {
            severidad = "Critica";
            respuesta = "Revocar accesos - Investigar brecha - Notificar afectados";
        }
        else if (datos >= 3)
        {
            severidad = "Alta";
            respuesta = "Cambiar contraseñas - Revisar logs de acceso";
        }
        else
        {
            severidad = "Media";
            respuesta = "Bloquear usuario - Alertar al propietario";
        }
        break;

    case 4: // Fuga de informacion
        if (datos >= 4)
        {
            severidad = "Critica";
            respuesta = "Investigar origen - Notificar autoridades - Comunicado oficial";
        }
        else if (datos >= 3)
        {
            severidad = "Alta";
            respuesta = "Identificar datos filtrados - Alertar afectados";
        }
        else
        {
            severidad = "Media";
            respuesta = "Revisar controles de acceso - Documentar incidente";
        }
        break;

    default:
        Console.WriteLine("Incidente no valido");
        return;
}

if (usuarios > 100)
{
    if (severidad == "Media")
    {
        severidad = "Alta";
    }
    else if (severidad == "Alta")
    {
        severidad = "Critica";
    }
}
else if (usuarios <= 5 && datos == 1)
{
    severidad = "Baja";
    respuesta = "Monitoreo basico - Documentar incidente";
}

Console.WriteLine("\n=== CLASIFICACION DE INCIDENTE ===");
Console.WriteLine("Severidad: " + severidad);
Console.WriteLine("Respuesta: " + respuesta);
