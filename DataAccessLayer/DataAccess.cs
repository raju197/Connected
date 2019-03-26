using AddressBookConnectedPractical;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public SqlCommandBuilder cmdbuilder;
        public DataRow dr;
        DataSet ds = new DataSet();
        Address s = new Address();

        public SqlConnection getConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());

            return con;
        }

        public void filldataintotable()
        {
            SqlConnection con = getConnection();
            da = new SqlDataAdapter("select * from AddressBook", con);
            da.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            cmdbuilder = new SqlCommandBuilder(da);
            da.Fill(ds);

        }
        public DataSet returndataset()
        {
            SqlConnection con = getConnection();
            da = new SqlDataAdapter("select * from AddressBook", con);
            da.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            cmdbuilder = new SqlCommandBuilder(da);
            da.Fill(ds);
            return ds;
        }

        public int InsertAddress(Address address)
        {
            
            int flag = 0;
            using (con = getConnection())
            {

                {


                    using (cmd = new SqlCommand("Insert into  AddressBook (FirstName, LastName, EmailId , PhoneNo) values (@FirstName, @LastName, @EmailId , @PhoneNo)", con))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", address.FistName);
                        cmd.Parameters.AddWithValue("@LastName", address.LastName);
                        cmd.Parameters.AddWithValue("@EmailId", address.EmailId);
                        cmd.Parameters.AddWithValue("@PhoneNo", address.PhoneNo);
                        con.Open();
                        flag = cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }
                return flag;

            }
        }
        public int UpdataAddress(int AddressId, Address addres)
        {
            int f1 = 0;
            using (con = getConnection())
            {
                using (cmd = new SqlCommand("Update AddressBook set FirstName = @FirstName, LastName = @LastName, EmailId = @EmailId  , PhoneNo = @PhoneNo where  AddressId =  @AddressId", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", addres.FistName);
                    cmd.Parameters.AddWithValue("@LastName", addres.LastName);
                    cmd.Parameters.AddWithValue("@EmailId", addres.EmailId);
                    cmd.Parameters.AddWithValue("@PhoneNo", addres.PhoneNo);
                    cmd.Parameters.AddWithValue("@AddressId", AddressId);
                    con.Open();
                    f1 = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return f1;
            }
        }
        public int DeleteAddress(int addressid)
        {
            int flag = 0;
            using (con = getConnection())
            
            

            {
                
                using (cmd = new SqlCommand("Delete AddressBook where AddressId = @AddressId", con))
                {


                    cmd.Parameters.AddWithValue("@AddressId", addressid);
                    con.Open();
                    flag = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return flag;



        }
        public Address Searchaddress(string LastName)
        {
            
           Address add = null;
            using (con = getConnection())
            {
                
                using (cmd = new SqlCommand("Select * from AddressBook where LastName = @LastName", con))
                {

                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    con.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        read.Read();
                        add = new Address();
                        add.AddressId = (int)read["AddressId"];
                        add.FistName = read["FirstName"].ToString();
                        add.LastName = read["LastName"].ToString();
                        add.EmailId = read["EmailId"].ToString();
                        add.PhoneNo = read["PhoneNo"].ToString();
                                   }
                    read.Close();
                    con.Close();
                }
            }
            return add;
        }




    }
}
