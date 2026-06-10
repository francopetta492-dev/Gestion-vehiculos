class Program
{
    static List<Auto> autos = new List<Auto>();
    static List<Moto> motos = new List<Moto>();
    static List<Camion> camiones = new List<Camion>();

    static void Main()
    {
        int op;
        do
        {
            Console.WriteLine("--Menu--");
            Console.WriteLine("1. Agregar auto");
            Console.WriteLine("2. Agregar moto");
            Console.WriteLine("3. Agregar camion");
            Console.WriteLine("4. Acelerar");
            Console.WriteLine("5. Frenar");
            Console.WriteLine("6. Mostrar vehículos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    CargarAuto();
                    break;
                case 2:
                    CargarMoto();
                    break;
                case 3:
                    CargarCamion();
                    break;
                case 4:
                    Acelerar();
                    break;
                case 5:
                    Frenar();
                    break;
                case 6:
                    MostrarInfo();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }while(op != 0);
    }

    static void CargarAuto()
    {
        Console.Write("Ingresar Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese la velocidad :");
        double velocidad = double.Parse(Console.ReadLine());

        autos.Add(new Auto(marca, velocidad));
    }

    static void CargarMoto()
    {
        Console.Write("Ingresar Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese la velocidad :");
        double velocidad = double.Parse(Console.ReadLine());

        motos.Add(new Moto(marca, velocidad));
    }

    static void CargarCamion()
    {
        Console.Write("Ingresar Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese la velocidad :");
        double velocidad = double.Parse(Console.ReadLine());

        camiones.Add(new Camion(marca, velocidad));
    }

    static void Acelerar()
    {
        Console.WriteLine("Acelerado...");
        foreach (var auto in autos)
        {
            auto.Acelerar();
        }
        foreach (var moto in motos)
        {
            moto.Acelerar();
        }
        foreach (var camion in camiones)
        {
            camion.Acelerar();
        }
    }
    static void Frenar()
    {
        Console.WriteLine("Frenando...");
        foreach (var auto in autos)
        {
            auto.Frenar();
        }
        foreach (var moto in motos)
        {
            moto.Frenar();
        }
        foreach (var camion in camiones)
        {
            camion.Frenar();
        }
    }

    static void MostrarInfo()
    {
        Console.WriteLine("--SISTEM DE GESTION DE VEHICULOS--");
        
        Console.WriteLine("=======================================");
        
        Console.WriteLine("Autos:");
        foreach (var auto in autos)
        {
            Console.WriteLine($"Marca: {auto.Marca}, Velocidad Actual: {auto.VelocidadActual}");
        }

        Console.WriteLine("=======================================");
        
        Console.WriteLine("Motos:");
        foreach (var moto in motos)
        {
            Console.WriteLine($"Marca: {moto.Marca}, Velocidad Actual: {moto.VelocidadActual}");
        }

        Console.WriteLine("=======================================");

        Console.WriteLine("Camiones:");
        foreach (var camion in camiones)
        {
            Console.WriteLine($"Marca: {camion.Marca}, Velocidad Actual: {camion.VelocidadActual}");
        }
    }
}