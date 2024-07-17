using DataLayer.config;
using EntitiesLayer.entities;
using System.Collections.Generic;
using Npgsql;

namespace DataLayer.repositories
{
    public class ProductsRepository: IProductsRepository
    {
        public Products GetById(int id)
        {
            using (var conn = ConnectorDB.GetInstance().CrearConexion())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM Products WHERE idProduct = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Products
                        {
                            IdProduct = reader.GetInt32(reader.GetOrdinal("idProduct")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Price = reader.GetDecimal(reader.GetOrdinal("price"))
                        };
                    }
                }
            }
            return null;
        }

        public List<Products> GetAll()
        {
            var products = new List<Products>();
            using (var conn = ConnectorDB.GetInstance().CrearConexion())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM Products", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Products
                        {
                            IdProduct = reader.GetInt32(reader.GetOrdinal("idProduct")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Price = reader.GetDecimal(reader.GetOrdinal("price"))
                        });
                    }
                }
            }
            return products;
        }

        public void Add(Products product)
        {
            using (var conn = ConnectorDB.GetInstance().CrearConexion())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO Products (name, description, price) VALUES (@name, @description, @price) RETURNING idProduct", conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                product.IdProduct = (int)cmd.ExecuteScalar();
            }
        }

        public void Update(Products product)
        {
            using (var conn = ConnectorDB.GetInstance().CrearConexion())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE Products SET name = @name, description = @description, price = @price WHERE idProduct = @id", conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@id", product.IdProduct);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = ConnectorDB.GetInstance().CrearConexion())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM Products WHERE idProduct = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        
        public List<Products> FindByName(string name)
        {
            List<Products> foundProducts = new List<Products>();
            using (var conn = ConnectorDB.GetInstance().CrearConexion())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM Products WHERE name ILIKE @name", conn); // ILIKE para búsqueda insensible a mayúsculas
                cmd.Parameters.AddWithValue("@name", $"%{name}%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foundProducts.Add(new Products
                        {
                            IdProduct = reader.GetInt32(reader.GetOrdinal("idProduct")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Price = reader.GetDecimal(reader.GetOrdinal("price"))
                        });
                    }
                }
            }
            return foundProducts;
        }
        
    }
}