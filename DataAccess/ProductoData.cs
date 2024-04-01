using System.Data.SqlClient;

namespace DataAccess
{
    public class ProductoData(string connectionString)
    {
        private readonly string _connectionString = connectionString;

        public List<Producto> GetAllProductos()
        {
            List<Producto> productos = [];

            using (SqlConnection connection = new(_connectionString))
            {
                string query = "SELECT Id, Nombre, Precio FROM Productos";
                SqlCommand command = new(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(
                        new Producto
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2)
                        }
                    );
                }
            }
            return productos;
        }


        public Producto GetProductoById(int id)
        {
            Producto producto = new();

            using (SqlConnection connection = new(_connectionString))
            {
                string query = "SELECT Id, Nombre, Precio FROM Productos WHERE Id=@Id";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    producto = 
                        new Producto
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2)
                        };
                }
            }
            return producto;
        }

        public void AddProducto(Producto producto)
        {
            using SqlConnection connection = new(_connectionString);
            string query = "INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@Nombre", producto.Nombre);
            command.Parameters.AddWithValue("@Precio", producto.Precio);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void UpdateProducto(Producto producto)
        {
            using SqlConnection connection = new(_connectionString);
            string query = "UPDATE Productos SET Nombre=@Nombre, Precio=@Precio WHERE Id=@Id";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@Id", producto.Id);
            command.Parameters.AddWithValue("@Nombre", producto.Nombre);
            command.Parameters.AddWithValue("@Precio", producto.Precio);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void DeleteProducto(int id)
        {
            using SqlConnection connection = new(_connectionString);
            string query = "DELETE FROM Productos WHERE Id=@Id";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}