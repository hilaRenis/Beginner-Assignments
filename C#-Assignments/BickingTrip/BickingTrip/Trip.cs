using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BickingTrip
{
    public class Trip
    {
        private string destination;
        private double distance;
        private double rating;

        private TransportationType _transportationType;


        public Trip(string destination, double distance, double rating)
        {
            this.destination = destination;
            this.distance = distance;
            this.rating = rating;
        }

        public Trip(string destination, double distance, double rating, TransportationType _transportationType)
        {
            this.destination = destination;
            this.distance = distance;
            this.rating = rating;
            this._transportationType = _transportationType;
        }

        public string GetDestination()
        {
            return this.destination;
        }

        public double GetDistance()
        {
            return this.distance;
        }

        public double GetRating()
        {
            return this.rating;
        }

        public TransportationType GetTransportationType()
        {
            return this._transportationType;
        }

        public string GetInfo()
        {
            return $"{this.destination} - dist. {this.distance}KM | rating {this.rating} ({this._transportationType})";
        }
    }
}
