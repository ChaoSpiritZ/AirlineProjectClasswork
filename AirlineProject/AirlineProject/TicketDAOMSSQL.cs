using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace AirlineProject
{

    class TicketDAOMSSQL : ITicketDAO
    {
        public void Add(Ticket t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Tickets VALUES ({t.ID}, {t.FlightId}, {t.CustomerId})", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public Ticket Get(int id)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Tickets where ID = {id}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine($"ID: {reader.GetValue(0)}, Flight ID: {reader.GetValue(1)}, Customer ID: {reader.GetValue(2)}");
                            Ticket ticket = new Ticket()
                            {
                                ID = reader.GetInt64(0),
                                FlightId = reader.GetInt64(1),
                                CustomerId = reader.GetInt64(2)
                            };
                            return ticket;
                        }
                        return null;
                    }
                }
            }
        }

        public List<Ticket> GetAll()
        {
            List<Ticket> tickets = new List<Ticket>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Tickets", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine($"ID: {reader.GetValue(0)}, Flight ID: {reader.GetValue(1)}, Customer ID: {reader.GetValue(2)}");
                            Ticket ticket = new Ticket()
                            {
                                ID = reader.GetInt64(0),
                                FlightId = reader.GetInt64(1),
                                CustomerId = reader.GetInt64(2)
                            };
                            tickets.Add(ticket);
                        }
                    }
                }
            }
            return tickets;
        }

        public void Remove(Ticket t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"DELETE FROM TICKETS WHERE ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public void Update(Ticket t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"update Tickets set ID = {t.ID}, FLIGHT_ID = {t.FlightId}, CUSTOMER_ID = {t.CustomerId} where ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }
    }
}
