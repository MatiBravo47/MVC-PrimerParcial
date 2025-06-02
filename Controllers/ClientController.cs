using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class ClientController
    {
        public Client CreateClient() => ClientView.CreateClient();
        public void ShowClient(Client cliente) => ClientView.ShowClient(cliente);
    }
}
