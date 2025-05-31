using Controllers;

class Program
{
    static void Main()
    {
        var controller = new ReservationController();
        controller.LoadReservations();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Crear nueva reserva");
            Console.WriteLine("2. Mostrar todas las reservas");
            Console.WriteLine("3. Eliminar reserva por cliente");
            Console.WriteLine("4. Actualizar reserva");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    controller.CreateReservation();
                    Console.ReadKey();
                    break;
                case "2":
                    controller.ShowAllReservations();
                    Console.ReadKey();
                    break;
                case "3":
                    controller.DeleteReservationByClient();
                    Console.ReadKey();
                    break;
                case "4":
                    controller.UpdateReservation();
                    Console.ReadKey();
                    break;
                case "5":
                    return;
            }
        }
    }
}
