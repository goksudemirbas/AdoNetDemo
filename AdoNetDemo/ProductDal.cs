using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=LAPTOP-EL89P9EQ;Integrated Security=True; initial catalog=ETrade");
        public DataTable GetAll()
        {
            ConnectionState();

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        private void ConnectionState()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        //public List<Product> GetAll2()
        //{
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }

        //    SqlCommand command = new SqlCommand("select * from Products", connection);

        //    SqlDataReader reader = command.ExecuteReader();

        //    List<Product> products = new List<Product>();

        //    while (reader.Read())
        //    {
        //        Product product = new Product
        //        {
        //            Id = Convert.ToInt32(reader["Id"]),
        //            Name = reader["Name"].ToString(),
        //            UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
        //            StockAmount = Convert.ToInt32(reader["StockAmount"])

        //        };
        //        products.Add(product);
        //    }


        //    reader.Close();
        //    connection.Close();
        //    return products;

        //}
        public void add(Product product)
        {
            ConnectionState();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@Unitprice,@StockAmount)", _connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();


        }
        public void update(Product product)
        {
            ConnectionState();
            SqlCommand command = new SqlCommand("update Products set Name=@name,UnitPrice=@UnitPrice,StockAmount=@StockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();


        }
        public void delete(int id)
        {
            ConnectionState();
            SqlCommand command = new SqlCommand("delete from Products where Id=@id", _connection);
            
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            _connection.Close();


        }


    }
}
