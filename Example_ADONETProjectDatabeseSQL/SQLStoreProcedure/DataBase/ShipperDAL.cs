using SQLStoreProcedure.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLStoreProcedure.DataBase
{
    public class ShipperDAL
    {

        string SQL=string.Empty;
        SqlConnection con = new SqlConnection(DataBase.Database.GetConnectingString);
        SqlCommand cmd;
        bool result;

        public bool Add(string companyName,string Phone)
        {
            SQL = "INSERT INTO Shippers Values('"+companyName+"','"+Phone+"')";
            cmd=new SqlCommand(SQL,con);

            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                int sonuc=cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result= true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }

            }
            return result;
        }

        public bool Update(int id, string companyName, string Phone)
        {
           // SQL = "update Shippers set CompanyName='"+companyName+"','"+"'Phone='"+Phone+"' where ShipperID='"+id;
            SQL = "UPDATE Shippers SET CompanyName=@CN, Phone=@PH WHERE ShipperID = @ID";
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@CN", companyName);
            cmd.Parameters.AddWithValue("@PH", Phone);
            cmd.Parameters.AddWithValue("@ID", id);
           


           
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }

            }
            return result;
        }

        public bool Delete(int id)
        {
            SQL = "delete from Shippers where ShipperID = " + id;
            cmd=new SqlCommand(SQL,con);

            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }

            }
            return result;
        }

        public string GetCompanyNameById(int id)
        {
            SQL = "select CompanyName from Shippers where ShipperID="  + id;
            string CompanyName;
            cmd = new SqlCommand(SQL, con);

            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                CompanyName = cmd.ExecuteScalar().ToString();
            
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }

            }
            return CompanyName;
        }

        public List<Shipper> GetShippers()
        {
            return null;
        }
    }
}
