using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reservation
    {
        public Client Client { get; set; }
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public double CalculateTotalWithTax() => Destinations.Sum(d =>d.PriceWithTax());
        public double CalculateTotal() => Destinations.Sum(d => d.BasePrice);
        public List<Destination> GetDestinations() => Destinations;
        public void SetDestinations(List<Destination> list) => Destinations = list;
    }
}