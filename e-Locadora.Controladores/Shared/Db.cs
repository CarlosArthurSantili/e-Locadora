using System;
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


    }
}
