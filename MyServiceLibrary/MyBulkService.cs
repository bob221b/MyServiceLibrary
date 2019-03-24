using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceLibrary
{
    class MyBulkService : IMyBulkService
    {
        public List<Country> GetAllContries()
        {
            List<Country> LC = new List<Country>();
            string conn = "Data Source=LENOVO-Z50;Initial Catalog=Bob_Database1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("Select * from apps_countries", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Country c = new Country();
                c.CountryID = int.Parse(dr[0].ToString());
                c.CountryCode = dr[1].ToString();
                c.CountryName = dr[2].ToString();
                LC.Add(c);
            }
            dr.Close();
            con.Close();
            return LC;
        }

        public string GetDetails(string sname)
        {
            return "Studnet name is:" + sname;
        }

        public double GetResult(int m1, int m2, int m3)
        {
            double avg = (m1 + m2 + m3) / 3.0;
            return avg;
        }

        public string GetResult1(int m1, int m2, int m3)
        {
            double avg = (m1 + m2 + m3) / 3.0;

            if (avg<35)
            {
                return "FAILED!!";
            }
            else
            {
                return "PASSED";
            }
        }
    }
}
