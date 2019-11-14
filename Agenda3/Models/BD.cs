using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Web;

namespace Agenda3.Models
{
    public class BD
    {
        private static SqlConnection Conectar()
        {
            string connectionString = "Server=.;Database=Agenda3;User Id=alumno;Password=alumno1;";
            SqlConnection a = new SqlConnection(connectionString);
            a.Open();
            return a;
        }
        public static void desconectar(SqlConnection Conexion)
        {
            Conexion.Close();
        }
        

        public static List<TiposEve> ListarTipoEve()
        {

            List<TiposEve> Lista = new List<TiposEve>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "select * from TiposEve";
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                int idTipEve = Convert.ToInt32(Lector["IdTipoEve"]);
                string TipEve = Lector["NombreT"].ToString();
                TiposEve UnEve = new TiposEve(idTipEve, TipEve);
                Lista.Add(UnEve);
            }
            desconectar(Conexion);
            return Lista;

        }
        public static List<TiposEve> TraerXTipEve(int Tipo)
        {
            TiposEve TE = new TiposEve();
            List<TiposEve> ListDeEven = new List<TiposEve>();

            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@tipo", Tipo);
            Consulta.CommandText = "sp_TraerxTipo";
            SqlDataReader Lector = Consulta.ExecuteReader();
           
            while (Lector.Read())
            {
                int idTipEve = Convert.ToInt32(Lector["IdTipoEve"]);
                string TipEve = Lector["NombreT"].ToString();
                TiposEve UnEveTip = new TiposEve(idTipEve, TipEve);
                ListDeEven.Add(UnEveTip);
            }
           
            desconectar(Conexion);
            return ListDeEven;
        }
        public static List<Amigos> ListarAmigos()
        {
          
            List<Amigos> ListaAmigos = new List<Amigos>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_TraerAmigos";
            desconectar(Conexion);
            return ListaAmigos;
        }
        public void AgregarAmigo(string nombre)
        {
            
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_InsertarAmigo";

            Consulta.Parameters.AddWithValue("@NomA", nombre);
//             Consulta.Parameters.AddWithValue("@NomA", nombre);
//            Consulta.Parameters.AddWithValue("@NomA", nombre);
//            Consulta.Parameters.AddWithValue("@NomA", nombre);

            Consulta.ExecuteNonQuery();
            
            desconectar(Conexion);
         
        }
        public void EliminarAmigo(string nombre)
        {

            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_EliminarAmigo";

            Consulta.Parameters.AddWithValue("@NomA", nombre);
            //             Consulta.Parameters.AddWithValue("@NomA", nombre);
            //            Consulta.Parameters.AddWithValue("@NomA", nombre);
            //            Consulta.Parameters.AddWithValue("@NomA", nombre);

            Consulta.ExecuteNonQuery();

            desconectar(Conexion);
        }

        public static List<Evento> ListarEventos()
        {

            List<Evento> ListaEventos = new List<Evento>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_TraerEve";
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                int IdEve = Convert.ToInt32(Lector["IdEve"]);
                string Nombre = Lector["Nombre"].ToString();
                int IdTEve = Convert.ToInt32(Lector["TipoEve"]);
                int IdAmi = Convert.ToInt32(Lector["IdAmigo"]);
                DateTime dia = Convert.ToDateTime(Lector["Dia"]);
                string descr = Lector["Descripcion"].ToString();
                bool Act = Convert.ToBoolean(Lector["Activo"]);
                bool destac = Convert.ToBoolean(Lector["Destac"]);
                Evento UnEven = new Evento(IdEve, Nombre, IdTEve, IdAmi, dia, descr, Act, destac);
                ListaEventos.Add(UnEven);
            }
            desconectar(Conexion);
            return ListaEventos;
        }

    }
}