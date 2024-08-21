using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Controlador
{
    public class CTipoServicio
    {
        public string Insertar(Modelos.MTipoServicio obj)
        {
            string rpt = string.Empty;
            try  //captura un error dentro del bloque try
            {
                using (SqlConnection SqlCon = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SqlCon;
                    cmd.Connection.Open();
                    cmd.CommandText = "insert into TipoServicio (ServiciosId,Tipo,Costo,Cant_Dispositivos) " +
                                        "values(@ServiciosId,@Tipo,@Costo,@Cant_Dispositivos)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@ServiciosId", obj.ServiciosID);
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Costo", obj.Costo);
                    cmd.Parameters.AddWithValue("@Cant_Dispositivos", obj.Cant_Dispositivos);
                    cmd.ExecuteNonQuery();
                    rpt = "Ok";
                }
            }
            catch (SqlException ex)
            {
                rpt = ex.Message;
            }
            return rpt;
        }

        public string Modificar(Modelos.MTipoServicio obj)
        {
            string rpt = string.Empty;
            try  //captura un error dentro del bloque try
            {
                using (SqlConnection SqlCon = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SqlCon;
                    cmd.Connection.Open();
                    cmd.CommandText = "update Servicios set Nombre = @Nombre ,FechaModificacion=@Fecha where Id=@Id";
                    cmd.CommandType = System.Data.CommandType.Text;

                    //cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    //cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.ExecuteNonQuery();
                    rpt = "Ok";
                }
            }
            catch (SqlException ex)
            {
                rpt = ex.Message;
            }
            return rpt;
        }
        public DataTable Buscar(int servicioID)
        {
            DataTable rpt = new DataTable();
            try  //captura un error dentro del bloque try
            {
                using (SqlConnection SqlCon = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SqlCon;
                    cmd.Connection.Open();
                    cmd.CommandText = "select TP.Id,Tp.ServiciosId,tp.Tipo,tp.Costo,tp.Cant_Dispositivos,tp.FechaCreacion,tp.FechaModificacion " +
                                        "from TipoServicio TP " +
                                        "where ServiciosId = @ServicioId";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@ServicioId", servicioID);

                    SqlDataAdapter Sqldt = new SqlDataAdapter(cmd);
                    Sqldt.Fill(rpt);

                }
            }
            catch (SqlException ex)
            {
                rpt = new DataTable();
            }
            return rpt;
        }
    }
}
