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
    public partial class FrmUsuarios : Form
    {
        public static bool cargar;
        public FrmUsuarios()
        {
            InitializeComponent();
            this.BackColor = Modelos.Variables.formBackColor;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Utils.DataGridStyle(DtUsuarios);
            Utils.DataGridStyle(DtTpoServicio);
            CargarDatos("");
            cargar = false;
            timer1.Start();
        }
        public void CargarDatos(string textoBuscar)
        {
            DtUsuarios.DataSource = new Controlador.CUsuarios().Buscar(textoBuscar);
            DtUsuarios.Refresh();
            //DtServicios.Columns["id"].Visible = false;
            DtUsuarios.Columns[0].Visible = false;
            DtUsuarios.Columns["Pass"].Visible = false;

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddUsuarios frm = new FrmAddUsuarios();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();
        }
        public static void BusquedaExterna()
        {
            new FrmUsuarios().CargarDatos("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(TxtBuscar.Text.Trim());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(cargar)
            {
                CargarDatos(TxtBuscar.Text.Trim());
                cargar = false;
            }
        }
    }
}
