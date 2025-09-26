using VeterinariaSanMiguel.Data;
using VeterinariaSanMiguel.Models;

namespace VeterinariaSanMiguel.Services;

public class VeterinarioService
{
    private readonly ApplicationDbContext _context = new ApplicationDbContext();

    private string PedirTexto(string mensaje)
    {
        string valor;
        do
        {
            Console.Write(mensaje);
            valor = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(valor))
            {
                Console.WriteLine("Error: este campo no puede estar vacío.");
                continue;
            }
            if (valor.All(char.IsDigit))
            {
                Console.WriteLine("Error: no se permiten solo números en este campo.");
                valor = "";
            }
        } while (string.IsNullOrWhiteSpace(valor));
        return valor;
    }

    private int PedirNumero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string valor = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(valor))
            {
                Console.WriteLine("Error: este campo no puede estar vacío.");
                continue;
            }
            if (!valor.All(char.IsDigit))
            {
                Console.WriteLine("Error: solo se permiten números en este campo.");
                continue;
            }
            return int.Parse(valor);
        }
    }

    public void RegistrarVeterinario()
    {
        try
        {
            string nombre = PedirTexto("Nombre: ");
            string apellido = PedirTexto("Apellido: ");
            string telefono = PedirNumero("Telefono: ").ToString();
            string especialidad = PedirTexto("Especialidad: ");
            var vet = new Veterinario { Nombre = nombre, Apellido = apellido, Telefono = telefono, Especialidad = especialidad };
            _context.Veterinarios.Add(vet);
            _context.SaveChanges();
            Console.WriteLine("Veterinario registrado correctamente.");
        }
        catch
        {
            Console.WriteLine("Error en el registro.");
        }
    }

    public void ListarVeterinarios()
    {
        try
        {
            var lista = _context.Veterinarios.ToList();
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay veterinarios registrados.");
                return;
            }
            Console.WriteLine("Lista de Veterinarios:");
            foreach (var v in lista)
            {
                Console.WriteLine($"{v.VeterinarioId} - {v.Nombre} {v.Apellido} - {v.Telefono} - {v.Especialidad}");
            }
        }
        catch
        {
            Console.WriteLine("Error al listar veterinarios.");
        }
    }

    public void EditarVeterinario()
    {
        try
        {
            int id = PedirNumero("Ingrese Id del veterinario: ");
            var vet = _context.Veterinarios.Find(id);
            if (vet == null)
            {
                Console.WriteLine("Veterinario no encontrado.");
                return;
            }
            vet.Telefono = PedirNumero("Nuevo telefono: ").ToString();
            vet.Especialidad = PedirTexto("Nueva especialidad: ");
            _context.SaveChanges();
            Console.WriteLine("Veterinario editado correctamente.");
        }
        catch
        {
            Console.WriteLine("Error al editar veterinario.");
        }
    }

    public void EliminarVeterinario()
    {
        try
        {
            int id = PedirNumero("Ingrese Id del veterinario: ");
            var vet = _context.Veterinarios.Find(id);
            if (vet == null)
            {
                Console.WriteLine("Veterinario no encontrado.");
                return;
            }
            _context.Veterinarios.Remove(vet);
            _context.SaveChanges();
            Console.WriteLine("Veterinario eliminado correctamente.");
        }
        catch
        {
            Console.WriteLine("Error al eliminar veterinario.");
        }
    }
}
