using VeterinariaSanMiguel.Mains;
    
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema Veterinaria San Miguel ===");

        while (true)
        {
            Console.WriteLine("\n--- Menú Principal ---");
            Console.WriteLine("1. Gestión de Veterinarios");
            Console.WriteLine("2. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    var menuVet = new MenuVeterinario();
                    menuVet.MostrarMenu();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}