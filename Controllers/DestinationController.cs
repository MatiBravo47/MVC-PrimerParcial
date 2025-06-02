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
        public List<Destination> LoadDestinationList() => DestinationView.LoadDestinationList();
        public void ShowDestination(List<Destination> destinationList) => DestinationView.ShowDestinationList(destinationList);
    }
}
