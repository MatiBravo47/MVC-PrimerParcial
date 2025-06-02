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
        //Se declaran las variables cController y dController
        private ClientController cController;
        private DestinationController dController;
        private List<Reservation> reservationList = new List<Reservation>();
        
        //Se inicializan cController y dController
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
            foreach (var reservacion in reservationList)
            {
                ReservationView.ShowMsg($"Indice: {indice}");
                cController.ShowClient(reservacion.Client);
                dController.ShowDestinationList(reservacion.Destinations);
                indice++;
            }
        }
        public void DeleteReservationByClient() 
        {
            ShowAllReservations();
            
            ReservationView.ShowMsg("Indique indice que desea eliminar");
            int indiceEliminar = int.Parse(Console.ReadLine());
            reservationList.RemoveAt(indiceEliminar);
            
            SaveReservations();
        } 
        public void UpdateReservation()
        {
            ShowAllReservations();
            
            ReservationView.ShowMsg("Ingrese el indice que desea actualizar");
            int indiceActualizar = int.Parse(Console.ReadLine());
            
            var nuevoCliente = cController.CreateClient();
            var nuevosDestinos = dController.LoadDestinationList();

            reservationList[indiceActualizar].Client = nuevoCliente;
            reservationList[indiceActualizar].Destinations = nuevosDestinos;
            
            SaveReservations() ;
        }
    }
}
