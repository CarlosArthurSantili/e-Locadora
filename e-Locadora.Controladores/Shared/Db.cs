﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores
{
    public delegate T ConverterDelegate<T>(IDataReader reader);
    public static class Db
    {
        private static readonly string bancoDeDados;
        private static readonly string connectionString = "";
        private static readonly string nomeProvider;
        private static readonly DbProviderFactory fabricaProvedor;

        static Db()
        {
            bancoDeDados = ConfigurationManager.AppSettings["bancoDeDados"];

            connectionString = ConfigurationManager.ConnectionStrings[bancoDeDados].ConnectionString;

            nomeProvider = ConfigurationManager.ConnectionStrings[bancoDeDados].ProviderName;

            fabricaProvedor = DbProviderFactories.GetFactory(nomeProvider);
        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = sql.AppendSelectIdentity();
                    command.Connection = connection;
                    command.SetParameters(parameters);

                    connection.Open();

                    int id = Convert.ToInt32(command.ExecuteScalar());

                    return id;
                }
            }
        }
        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }
        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    var list = new List<T>();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var obj = convert(reader);
                            list.Add(obj);
                        }

                        return list;
                    }
                }
            }
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    T t = default;

                    using (IDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                            t = convert(reader);

                        return t;
                    }
                }
            }
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    int numberRows = Convert.ToInt32(command.ExecuteScalar());

                    return numberRows > 0;
                }
            }
        }
    }
}
