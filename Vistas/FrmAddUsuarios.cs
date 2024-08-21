using Servicios_Streaming.Controlador;
using Servicios_Streaming.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Streaming.Vistas
{
    public partial class FrmAddUsuarios : Form
    {
        public FrmAddUsuarios()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MUsuarios User = new MUsuarios
            {
                Nombres = TxtNombre.Text.Trim(),
                Apellidos = TxtApellidos.Text.Trim(),
                Telefono = TxtTelefono.Text.Trim(),
                Direccion = TxtDireccion.Text.Trim(),
                Email = TxtEmail.Text.Trim(),
                UserName = TxtUser.Text.Trim(),
                Pass = TxtPass.Text.Trim()
            };
            string rpt = new CUsuarios().Insertar(User);
            if (rpt.Equals("Ok"))
            {
                Utils.Mensaje("Registro Insertado Exitosamente.");
                FrmUsuarios.cargar=true;
                this.Dispose();
            }
            else
            {
                Utils.Mensaje(rpt, true);
            }
        }

        private void FrmAddUsuarios_Load(object sender, EventArgs e)
        {
            ActiveControl = TxtNombre;
        }
    }
}
