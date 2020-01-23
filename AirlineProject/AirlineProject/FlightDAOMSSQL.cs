using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class FlightDAOMSSQL : IFlightDAO
    {
        public void Add(Flight t)
        {
            throw new NotImplementedException();
        }

        public Flight Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Flight, int> GetAllFlightsVacancy()
        {
            throw new NotImplementedException();
        }

        public Flight GetFlightById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByDepartureDate(DateTime departureDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByDestinationCountry(int countryCode)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByLandingDate(DateTime landingDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByOriginCountry(int countryCode)
        {
            throw new NotImplementedException();
        }

        public void Remove(Flight t)
        {
            throw new NotImplementedException();
        }

        public void Update(Flight t)
        {
            throw new NotImplementedException();
        }
    }
}
