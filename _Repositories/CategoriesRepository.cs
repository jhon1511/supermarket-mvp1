using Microsoft.Data.SqlClient;
using Supermarket_mvp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString) 
        { 
            this.connectionString = connectionString;
        }
        public void Add(CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @Observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoriesModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Categories WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories
                                        SET CategoriesName =@name,
                                        CategoriesObservation = @observation
                                        WHERE CategoriesId = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoriesModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriesModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categorieList = new List<CategoriesModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Categories ORDER BY CategorieId DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["CategorieId"];
                        categoriesModel.Name = reader["CategorieName"].ToString();
                        categoriesModel.Observation = reader["CategorieObservation"].ToString();
                        categorieList.Add(categoriesModel);
                    }
                }
            }
            return categorieList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categorieList = new List<CategoriesModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories
                                        WHERE CategorieId=@id or CategorieName LIKE @name+ '%'
                                        ORDER By CategorieId DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategoriesModel();
                        categorieModel.Id = (int)reader["CategorieId"];
                        categorieModel.Name = reader["CategorieName"].ToString();
                        categorieModel.Observation = reader["CategorieObservation"].ToString();
                        categorieList.Add(categorieModel);
                    }
                }
            }
            return categorieList;
        }
    }
}
