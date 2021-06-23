using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Npgsql;

namespace StoredProcedureTest.Data
{
    public class WeathersRepository
    {
        private readonly string _connectionString;
        
        public WeathersRepository(string connStr) =>
            _connectionString = connStr;

        public List<WeatherForecast> GetAll()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Query<WeatherForecast>("SELECT * FROM weather_forecasts").ToList();
        }

        public int ChangeTemperature(int id, int temperature)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Execute($"CALL change_temperature({id}, {temperature});");
        }
    }
}