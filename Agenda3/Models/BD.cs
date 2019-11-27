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
        //aaaaaa
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
            Consulta.CommandText = "sp_TraerTipos";
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


        public static List<Evento> TraerXTipEve(int Tipo)
        {
          
            List<Evento> ListDeEven = new List<Evento>();

            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@tipo", Tipo);
            Consulta.CommandText = "sp_TraerxTipo";
            SqlDataReader Lector = Consulta.ExecuteReader();
           
            while (Lector.Read())
            {
                if (Lector["IdAmigo"] == DBNull.Value)
                {
                    int IdEve = Convert.ToInt32(Lector["IdEve"]);
                    string Nombre = Lector["Nombre"].ToString();
                    int IdTEve = Convert.ToInt32(Lector["TipoEve"]);
                    DateTime dia = Convert.ToDateTime(Lector["Dia"]);
                    string descr = Lector["Descripcion"].ToString();
                    bool Act = Convert.ToBoolean(Lector["Activo"]);
                    bool destac = Convert.ToBoolean(Lector["Destac"]);
                    Evento UnEveTip = new Evento(IdEve, Nombre, IdTEve, dia, descr, Act, destac);
                    ListDeEven.Add(UnEveTip);
                }
                else
                {
                    int IdEve = Convert.ToInt32(Lector["IdEve"]);
                    string Nombre = Lector["Nombre"].ToString();
                    int IdTEve = Convert.ToInt32(Lector["TipoEve"]);
                    int IdAmi = Convert.ToInt32(Lector["IdAmigo"]);
                    DateTime dia = Convert.ToDateTime(Lector["Dia"]);
                    string descr = Lector["Descripcion"].ToString();
                    bool Act = Convert.ToBoolean(Lector["Activo"]);
                    bool destac = Convert.ToBoolean(Lector["Destac"]);
                    Evento UnEveTip = new Evento(IdEve, Nombre, IdTEve, IdAmi, dia, descr, Act, destac);
                    ListDeEven.Add(UnEveTip);
                }

            }
           
            desconectar(Conexion);
            return ListDeEven;
        }

        public static Evento TraerUnEvento(int idEvento)
        {
            Evento UnEvento = new Evento();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@id", idEvento);
            Consulta.CommandText = "sp_TraerUnEven";
            SqlDataReader Lector = Consulta.ExecuteReader();

            while (Lector.Read())
            {
                if (Lector["IdAmigo"] == DBNull.Value)
                {
                    UnEvento.IdEve = Convert.ToInt32(Lector["IdEve"]);
                    UnEvento.Nombre = Lector["Nombre"].ToString();
                    UnEvento.IdTipEve = Convert.ToInt32(Lector["TipoEve"]);
                    UnEvento.Dia = Convert.ToDateTime(Lector["Dia"]);
                    UnEvento.Descripcion = Lector["Descripcion"].ToString();
                    UnEvento.Activo = Convert.ToBoolean(Lector["Activo"]);
                    UnEvento.Destac = Convert.ToBoolean(Lector["Destac"]);
                }
                else
                {
                    UnEvento.IdEve = Convert.ToInt32(Lector["IdEve"]);
                    UnEvento.Nombre = Lector["Nombre"].ToString();
                    UnEvento.IdTipEve = Convert.ToInt32(Lector["TipoEve"]);
                    UnEvento.IdAmigo = Convert.ToInt32(Lector["IdAmigo"]);
                    UnEvento.Dia = Convert.ToDateTime(Lector["Dia"]);
                    UnEvento.Descripcion = Lector["Descripcion"].ToString();
                    UnEvento.Activo = Convert.ToBoolean(Lector["Activo"]);
                    UnEvento.Destac = Convert.ToBoolean(Lector["Destac"]);
                }
            }

            desconectar(Conexion);
            return UnEvento;

        }


        public static List<Amigos> ListarAmigos()
        {
            
            List<Amigos> ListaAmigos = new List<Amigos>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_TraerAmigos";
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                Amigos UnAmigo = new Amigos();
                UnAmigo.IdAmigo = Convert.ToInt32(Lector["IdAmigo"]);
                UnAmigo.Nombre = Lector["Nombre"].ToString();
                UnAmigo.Activo = Convert.ToBoolean(Lector["Activo"]);
                ListaAmigos.Add(UnAmigo);
            }
             desconectar(Conexion);
            return ListaAmigos;
        }
        public static void AgregarAmigo(string nombre,bool activo)
        {
            
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_InsertarAmigo";
            Consulta.Parameters.AddWithValue("@NomA", nombre);
            Consulta.Parameters.AddWithValue("@Act", activo);
            Consulta.ExecuteNonQuery();
            desconectar(Conexion);
        }
        public static void EliminarAmigo(int id)
        {

            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.CommandText = "sp_EliminarAmigo";
            Consulta.Parameters.AddWithValue("@NomA", id);
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
                if(Lector["IdAmigo"] == DBNull.Value)
                {
                    int IdEve = Convert.ToInt32(Lector["IdEve"]);
                    string Nombre = Lector["Nombre"].ToString();
                    int IdTEve = Convert.ToInt32(Lector["TipoEve"]);  
                    DateTime dia = Convert.ToDateTime(Lector["Dia"]);
                    string descr = Lector["Descripcion"].ToString();
                    bool Act = Convert.ToBoolean(Lector["Activo"]);
                    bool destac = Convert.ToBoolean(Lector["Destac"]);
                    Evento UnEven = new Evento(IdEve, Nombre, IdTEve, dia, descr, Act, destac);
                    ListaEventos.Add(UnEven);
                }
                else
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
            }
            desconectar(Conexion);
            return ListaEventos;
        }

    }
}