using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Controlador
{
    internal class CServicios
    {
        public string Insertar(Modelos.MServicio obj) { 
            string rpt = string.Empty;
            try  //captura un error dentro del bloque try
            {
                using (SqlConnection SqlCon = new SqlConnection(Conexion.cn)) { 
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SqlCon;
                    cmd.Connection.Open();
                    cmd.CommandText = "insert into Servicios(Nombre) values(@Nombre)";
                    cmd.CommandType=System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.ExecuteNonQuery();
                    rpt = "Ok";
                }
            }
            catch (SqlException ex)
            {
                rpt=ex.Message;
            }
            return rpt;
        }

        public string Modificar(Modelos.MServicio obj)
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

                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
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
        public DataTable Buscar(string Nombre)
        {
            DataTable rpt = new DataTable();
            try  //captura un error dentro del bloque try
            {
                using (SqlConnection SqlCon = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SqlCon;
                    cmd.Connection.Open();
                    cmd.CommandText = "Select * from Servicios where Nombre LIKE '%'+ @Nombre + '%'";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    
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
