using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Agenda3.Models
{
    public class BD
    {
        public static string connectionString = "Server=.;Database=Agenda3;Trusted_Connection=True;";
        private static SqlConnection Conectar()
        {
            SqlConnection Conn = new SqlConnection(connectionString);
            Conn.Open();
            return Conn;
        }
        public static void desconectar(SqlConnection Conexion)
        {
            Conexion.Close();
        }
        

        public static List<TiposEve> ListarNoticias()
        {

            List<TiposEve> Lista = new List<TiposEve>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * From TiposDeEventos";
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                TiposEve Eventos = new TiposEve();
                Eventos.idTipEve = Convert.ToInt32(dataReader["idTipoEve"]);
                EVentos.TipEve = dataReader["NombreT"].ToString();
                
                Lista.Add(Eventos);
            }
            desconectar(Conexion);
            return Lista;

        }
    }
}