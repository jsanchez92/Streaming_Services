using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Controlador
{
    public class CUsuarios
    {
        public string Insertar(Modelos.MUsuarios obj)
        {
            string rpt = string.Empty;
            try  //captura un error dentro del bloque try
            {
                using (SqlConnection SqlCon = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SqlCon;
                    cmd.Connection.Open();
                    cmd.CommandText = "if((isnull((select id from Usuarios where Email=@Email),0))=0) begin "+
                        "insert into Usuarios(Nombres,Apellidos,Telefono,Direccion,Email,UserName,Pass) " +
                        "values(@Nombres,@Apellidos,@Telefono,@Direccion,@Email,@UserName,@Pass) " +
                        "end " +
                        "else " +
                        "begin " +
                        "raiserror('El Usuario ya existe.',1,16) " +
                        " end";
                    cmd.CommandType = System.Data.CommandType.Text;


                    cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.Parameters.AddWithValue("@UserName", obj.UserName);
                    cmd.Parameters.AddWithValue("@Pass", obj.Pass);
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
                    cmd.CommandText = "Select Id,Nombres,Apellidos,Telefono,Direccion,Email,UserName,Pass " +
                        "from Usuarios where Nombres+Email LIKE '%'+ @Nombres + '%'";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@Nombres", Nombre);

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
