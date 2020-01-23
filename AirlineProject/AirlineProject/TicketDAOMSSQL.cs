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
                using(SqlCommand cmd = new SqlCommand("", con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
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
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }

            }
        }

        public List<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Ticket t)
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket t)
        {
            throw new NotImplementedException();
        }
    }
}
