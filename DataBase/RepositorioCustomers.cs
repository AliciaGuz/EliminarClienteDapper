using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static DataBase.RepositorioCustomers;

namespace DataBase
{
    public class RepositorioCustomers
    {
        public List<Customers> ObtenerTodo()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelcetAll = "";
                SelcetAll = SelcetAll + "SELECT [CustomerID] " + "\n";
                SelcetAll = SelcetAll + "      ,[CompanyName] " + "\n";
                SelcetAll = SelcetAll + "      ,[ContactName] " + "\n";
                SelcetAll = SelcetAll + "      ,[ContactTitle] " + "\n";
                SelcetAll = SelcetAll + "  FROM [dbo].[Customers]";

                var cliente = conexion.Query<Customers>(SelcetAll).ToList();
                return cliente;


            }
        }

        public Customers ObtenerPorID(string id)
        {

            using (var conexion = DataBase.GetSqlConnection())
            {

                String selectPorID = "";
                selectPorID = selectPorID + "SELECT [CustomerID] " + "\n";
                selectPorID = selectPorID + "      ,[CompanyName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactTitle] " + "\n";
                selectPorID = selectPorID + "  FROM [dbo].[Customers] " + "\n";
                selectPorID = selectPorID + "  WHERE CustomerID = @CustomerID";

                var Cliente = conexion.QueryFirstOrDefault<Customers>(selectPorID, new { CustomerID = id });
                return Cliente;
            }
        }

        public int EliminarCliente(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                string deleteQuery = @"
            DELETE FROM [dbo].[Customers] 
            WHERE CustomerID = @CustomerID";

                var eliminadas = conexion.Execute(deleteQuery, new { CustomerID = id });

                return eliminadas;
            }
        }



    }
}
