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
    internal class ProviderRepository : BaseRepository, IProvidersRepository
    {
        public ProviderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProvidersModel providersModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProvidersModel providersModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProvidersModel> GetAll()
        {
            var providerList = new List<ProvidersModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Providers ORDER BY Provider_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProvidersModel();
                        providerModel.Id = (int)reader["Provider_Id"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerModel.Observation = reader["Provider_Observation"].ToString();
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providersList = new List<ProvidersModel>();
            int providersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers
                                        WHERE Provider_Id=@id or Provider_Name LIKE @name+ '%'
                                        ORDER By Provider_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProvidersModel();
                        providerModel.Id = (int)reader["Provider_Id"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerModel.Observation = reader["Provider_Observation"].ToString();
                        providersList.Add(providerModel);
                    }
                }
            }
            return providersList;
        }
    }
}
