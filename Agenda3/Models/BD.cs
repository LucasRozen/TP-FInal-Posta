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
        private static SqlConnection conectar()
        {
            System.Security.SecureString contra = new NetworkCredential("", "alumno").SecurePassword;
            contra.MakeReadOnly();
            string connectionString = "Server=.;Database=Agenda3;Trusted_Connection=True;Integrated Security=false;";​
            SqlConnection a = new SqlConnection(connectionString);​
            SqlCredential usr = new SqlCredential("alumno", contra);​
            a.Credential = usr;​
            a.Open();​
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
            Consulta.CommandText = "sp_TraerTipos";     
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
            Consulta.CommandText = "sp_TraerxTipo";

            Consulta.Parameters.AddWithValue("@tipo", TE.TipEve);
            //             Consulta.Parameters.AddWithValue("@NomA", nombre);
            //            Consulta.Parameters.AddWithValue("@NomA", nombre);
            //            Consulta.Parameters.AddWithValue("@NomA", nombre);

            Consulta.ExecuteNonQuery();

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
            desconectar(Conexion);
            return ListaEventos;
        }

    }
}