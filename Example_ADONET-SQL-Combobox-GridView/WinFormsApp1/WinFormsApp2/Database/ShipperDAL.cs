using System.Data.SqlClient;
using WinFormsApp2.Business;

namespace WinFormsApp2.Database
{
    public class ShipperDAL
    {
        string sql = string.Empty;
        SqlConnection conn = new SqlConnection(Database.GetConnectionString);
        SqlCommand cmd;
        bool result;

        public bool Add(string companyName, string phone)
        {
            sql = "INSERT INTO Shippers VALUES('" + companyName + "','" + phone + "')";
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally 
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public bool Update(int id, string companyName, string phone)
        {
            sql = "UPDATE Shippers SET CompanyName = '" + companyName + "', Phone = '" + phone + "' WHERE ShipperID = " + id;
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public bool Delete(int id)
        {
            sql = "DELETE FROM Shippers WHERE ShipperID = " + id;
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public string GetCompanyNameById(int id)
        {
            sql = "SELECT CompanyName FROM Shippers WHERE ShipperID = " + id;
            string companyName = string.Empty;

            try
            {
                cmd = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                companyName = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return companyName;
        }

        public List<Shipper> GetShippers()
        {
            sql = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
            List<Shipper> _shippers = new List<Shipper>();

            try
            {
                cmd = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _shippers.Add(new Shipper((int)dr["ShipperID"], dr[1].ToString(), dr[2].ToString()));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return _shippers;
        }
    }
}
