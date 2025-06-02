using System.Reflection;

namespace Views
{
    using Models;

    public static class ClientView
    {
        public static Client CreateClient()
        {
            Console.WriteLine("=== Crear Cliente ===");
            
            Console.Write("Nombre: ");
            string name = Console.ReadLine();

            Console.Write("Apellido: ");
            string lastName = Console.ReadLine();
            
            Console.Write("ID (DNI o Pasaporte): ");
            string id = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new Client(name, lastName, id, email);
        }

        public static void ShowClient(Client client)
        {
            Console.WriteLine($"Cliente: {client.Name} { client.LastName} -ID: { client.ID} -Email: { client.Email}"); 
        }
    }
}
