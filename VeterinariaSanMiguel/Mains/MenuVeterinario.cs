using VeterinariaSanMiguel.Services;

namespace VeterinariaSanMiguel.Mains;

public class MenuVeterinario
{
    private readonly VeterinarioService _service = new VeterinarioService();

    public void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Gestión de Veterinarios ---");
            Console.WriteLine("1. Registrar veterinario");
            Console.WriteLine("2. Listar veterinarios");
            Console.WriteLine("3. Editar veterinario");
            Console.WriteLine("4. Eliminar veterinario");
            Console.WriteLine("5. Volver al menú principal");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    _service.RegistrarVeterinario();
                    break;
                case "2":
                    _service.ListarVeterinarios();
                    break;
                case "3":
                    _service.EditarVeterinario();
                    break;
                case "4":
                    _service.EliminarVeterinario();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}