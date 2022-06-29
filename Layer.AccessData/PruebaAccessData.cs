using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Layer.Entity;

namespace Layer.AccessData
{
    public class PruebaAccessData
    {
        public static List<PruebaEntity> Listar()
        {
            var lista = new List<PruebaEntity>();
            string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PruebaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_PruebaListar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader drlector = cmd.ExecuteReader();


            while (drlector.Read())
            {
                PruebaEntity oPruebaEntity = new PruebaEntity();
                oPruebaEntity.PruebaID = Convert.ToInt32(drlector["PruebaID"]);
                oPruebaEntity.PruebaName = drlector["PruebaName"].ToString().Trim();
                oPruebaEntity.PruebaDesc = drlector["PruebaDesc"].ToString().Trim();
               
                lista.Add(oPruebaEntity);
            }
            return lista;
        }
    }
}