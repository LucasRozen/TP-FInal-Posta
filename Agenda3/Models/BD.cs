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
        

        public static List<TiposEve> ListarEve()
        {

            List<TiposEve> Lista = new List<TiposEve>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * From TiposEve";
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                TiposEve Eventos = new TiposEve();
                Eventos.IdTipEve = Convert.ToInt32(dataReader["idTipoEve"]);
                Eventos.TipEve = dataReader["NombreT"].ToString();
                
                Lista.Add(Eventos);
            }
            desconectar(Conexion);
            return Lista;

        }
        public static List<TiposEve> TraerXTipEve(int Tipo)
        {
            List<TiposEve> ListDeEven = new List<TiposEve>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * FROM TiposEve WHERE idTipoEve = '" + Tipo + "' ";
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                TiposEve UnEven = new TiposEve();

                UnEven.IdTipEve = Convert.ToInt32(dataReader["idTipoEve"]);
                UnEven.TipEve = dataReader["NombreT"].ToString();
               

                ListDeEven.Add(UnEven);

            }
            desconectar(Conexion);
            return ListDeEven;
        }
    }
}