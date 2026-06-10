class Program
{
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
}
