using BaseBackend.Interface;
using BaseBackend.Models;
using System.Data.SqlClient;
namespace BaseBackend.Services;


public class OwnerService : IBaseService<Owner>
{
    public void Add(Owner owner)
    {
        const string ConnectionString = "Data Source=.; Initial Catalog=RentPanel.DB; Trusted_Connection=True;";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {

            connection.Open();

            string query = $"INSERT INTO dbo.Owner(FirstName,LastName,NationalCode,PhoneNumber)" +
                " Values(@FirstName,@LastName,@NationalCode,@PhoneNumber)";

            SqlCommand command = new SqlCommand(query, connection) ;
            command.Parameters.AddWithValue("@FirstName", owner.FirstName);
            command.Parameters.AddWithValue("@LastName", owner.LastName);
            command.Parameters.AddWithValue("@NationalCode", owner.NationalCode);
            command.Parameters.AddWithValue("@PhoneNumber", owner.PhoneNumber);

            Console.WriteLine("FirstName = " + owner.FirstName);
            Console.WriteLine("LastName = " +owner.LastName);
            Console.WriteLine("NationalCode = "+owner.NationalCode);
            Console.WriteLine("PhoneNumber + " + owner.PhoneNumber);

            int rowAffected = command.ExecuteNonQuery();
        }
    }
    public void Delete(int id)
    {
        //connect5 db
        const string connectionString = "Data Source=.;Initial Catalog=RentPanel.DB;Trusted_Connection=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            connection.Open();
            string query = $"Delete  dbo.Owner Where Id=@Id ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);
            //execute insert query
            int rowsAffected = command.ExecuteNonQuery();
        }
    }
    public List<Owner> GetAll()
    {
        List<Owner> owners = new List<Owner>();
        const string ConnectionString = "Data Source=.;Initial Catalog=RentPanel.DB;Trusted_Connection=True;";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            try
            {
                connection.Open();
                string query = $"Select * from dbo.Owner ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Owner owner = new Owner()
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        NationalCode = reader["NationalCode"].ToString(),
                        PhoneNumber = reader["PhoneNumbe"].ToString(),
                    };
                    owners.Add(owner);

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error={ex.Message}");

            }
            finally
            {
                connection.Close();
            }
            return owners;

        }



    }

    public void Update(Owner item)
    {
        const string ConnectionString = "DataSource=.;IniatialCatalog=RentPanel.DB;Trusted_Connection=True;";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {

            connection.Open();
            string query = $"UPDATE dbo.Owner SET PhoneNumber=@PhoneNumber,FirstName=@FirstName,LastName = @LastName,Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);

            // item ro az oon public void update owner item mifahmim ke bayad in ja item bezarim
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@LastName", item.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
            command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
            command.Parameters.AddWithValue("@Id",item.Id);

            int rowsAffected = command.ExecuteNonQuery();


        

        }
    }
}

