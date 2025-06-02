using System.Reflection;

namespace Views
{
    using Models;
    public static class DestinationView
    {
        public static Destination LoadDestination()
        {
            Console.WriteLine("=== Crear Destino Turístico ===");
            
            Console.Write("Nombre del destino: ");
            string name = Console.ReadLine();

            Console.Write("País: ");
            string country = Console.ReadLine();

            Console.Write("Precio base: ");
            double basePrice;
            while (!double.TryParse(Console.ReadLine(), out basePrice))
            {
                Console.Write("Precio inválido. Ingrese un número: "); 
            }

            return new Destination(name, basePrice, country);
        }
        public static List<Destination> LoadDestinationList() 
        {
            string resp = "n";
            List<Destination> tempList = new List<Destination>();
            do
            {
                tempList.Add(LoadDestination());
                Console.WriteLine("Desea ingresar otro destino?");
                resp = Console.ReadLine();
            } while (resp.ToLower() != "n");
            return tempList;    
        }
        public static void ShowDestination(Destination destination)
        {
            Console.WriteLine($"Destino: {destination.Name} - País:{ destination.Country} -Precio Base: { destination.BasePrice:C}- Precio con Impuesto: { destination.PriceWithTax():C}"); 
        }
        public static void ShowDestinationList(List<Destination> productList) 
        {
            foreach (Destination destino in productList) 
            {
                ShowDestination(destino);
            }
        }

    }
}
