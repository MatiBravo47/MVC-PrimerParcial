using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;
using System.Collections;
using Views;

namespace Controllers
{
    public class ReservationController
    {
        private ClientController cController;
        private DestinationController dController;
        private List<Reservation> reservationList = new List<Reservation>();
        public ReservationController()
        {
            cController = new ClientController();
            dController = new DestinationController();
            LoadReservations();
        }

        public void LoadReservations()
        {
            reservationList = Repository<Reservation>.ObtenerTodos("Ordenes");
        }

        public void SaveReservations()
        {
            Repository<Reservation>.GuardarLista("Ordenes", reservationList);
        }

        // MÉTODOS A COMPLETAR: 
        public void CreateReservation() {
            var cliente = cController.CreateClient();
            var destino = dController.LoadDestinationList();

            Reservation nuevaReservacion = new Reservation();
            nuevaReservacion.Client = cliente;
            nuevaReservacion.Destinations = destino;
            reservationList.Add(nuevaReservacion);
            SaveReservations();
        }
        public void ShowAllReservations()
        {
            int indice = 0;
            foreach (var o in reservationList)
            {
                ReservationView.ShowMsg($"Indice: {indice}");
                ClientView.ShowClient(o.Client);
                DestinationView.ShowDestinationList(o.Destinations);
                indice++;
            }
        }
        public void DeleteReservationByClient() 
        {
            ShowAllReservations();
            ReservationView.ShowMsg("Indique indice que desea eliminar");
            int indiceIndicado = int.Parse(Console.ReadLine());
            reservationList.RemoveAt(indiceIndicado);
            SaveReservations();
        } 
        public void UpdateReservation()
        {
            ShowAllReservations();
            ReservationView.ShowMsg("Ingrese el indice que desea actualizar");
            int indiceSelec = int.Parse(Console.ReadLine());
            var nuevoCliente = cController.CreateClient();
            var nuevosDestinos = dController.LoadDestinationList();

            reservationList[indiceSelec].Client = nuevoCliente;
            reservationList[indiceSelec].Destinations = nuevosDestinos;
            SaveReservations() ;
        }
    }
}
