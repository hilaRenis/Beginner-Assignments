using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BickingTrip
{
    public class BickingService
    {
        private string name;

        private List<Trip> trips;

        public BickingService(string name)
        {
            this.name = name;

            this.trips = new List<Trip>();
        }

        public void AddTrip(string destination, double distance, double rating, TransportationType _transportationType)
        {
            this.trips.Add(new Trip(destination, distance, rating, _transportationType));
        }

        public Trip[] GetTrips()
        {
            return this.trips.ToArray();
        }

        public Trip[] GetTrips(string destination)
        {
            List<Trip> foundtrips = new List<Trip>();

            foreach (Trip t in this.trips)
            {
                if (t.GetDestination().Contains(destination))
                { foundtrips.Add(t); }
            }

            return foundtrips.ToArray();
        }

        public Trip[] GetTripsByRating(double ratingmin, double ratingmax)
        {
            List<Trip> foundtrips = new List<Trip>();

            foreach (Trip t in this.trips)
            {
                if (t.GetRating() >= ratingmin && t.GetRating() <= ratingmax)
                { foundtrips.Add(t); }
            }

            return foundtrips.ToArray();
        }

        public void RemoveTrip(Trip t)
        {
            this.trips.Remove(t);
        }

        public void RemoveTripAt(int t)
        {
            this.trips.RemoveAt(t);
        }
    }
}
