class Program
{
    static List<Vehiculo> autos = new List<Vehiculo>();
    static List<Vehiculo> moto = new List<Vehiculo>();
    static List<Vehiculo> camion = new List<Vehiculo>();

    static void Main()
    {
        int op;
        do
        {
            Console.WriteLine("--Menu--");
            Console.WriteLine("1. Agregar auto");
            Console.WriteLine("2. Agregar moto");
            Console.WriteLine("3. Agregar camion");
            Console.Write("Seleccione una opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
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
}