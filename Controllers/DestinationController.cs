using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class DestinationController
    {
        public DestinationController() { }
        public Destination LoadDestination() 
        {
            return DestinationView.LoadDestination();
        }
        public List<Destination> LoadDestinationList() 
        {
            return DestinationView.LoadDestinationList();
        }
        public void ShowDestination(List<Destination> destinationList) 
        {
            DestinationView.ShowDestinationList(destinationList);
        }
    }
}
