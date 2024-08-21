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
    public partial class FrmServicios : Form
    {
        int IdServicio = 0;
        public FrmServicios()
        {
            InitializeComponent();
            this.BackColor = Modelos.Variables.formBackColor;
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            Utils.DataGridStyle(DtServicios);
            Utils.DataGridStyle(DtTpoServicio);
            CargarDatos("");
        }



        void CargarDatos(string textoBuscar)
        {
            DtServicios.DataSource = new Controlador.CServicios().Buscar(textoBuscar);
            DtServicios.Refresh();
            //DtServicios.Columns["id"].Visible = false;
            DtServicios.Columns[0].Visible = false;

        }



        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(TxtBuscar.Text.Trim());
        }
        public static void BusquedaExterna()
        {
            new FrmServicios().CargarDatos("");
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            PnNew.Visible = true;
            PnNew.Dock = DockStyle.Fill;
            PnNew.BringToFront();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MServicio obj = new MServicio { Nombre = TxtNombre.Text.Trim() };
            string r = new Controlador.CServicios().Insertar(obj);
            if (r.Equals("Ok"))
            {
                MessageBox.Show("Registro Insertado Correctamente.");
                PnNew.Visible = false;
                TxtNombre.Clear();
                CargarDatos("");
            }
            else
            {
                MessageBox.Show(r);
            }
        }

        private void DtServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (DtServicios.Rows.Count > 0)
            {
                IdServicio = Convert.ToInt32(DtServicios.CurrentRow.Cells["ID"].Value);
                BuscarTipoServicio();
            }
        }

        void BuscarTipoServicio()
        {
            try
            {
                DtTpoServicio.DataSource = new Controlador.CTipoServicio().Buscar(IdServicio);
                DtTpoServicio.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DtServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //BuscarTipoServicio();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarTipoServicio frm = new FrmAgregarTipoServicio();
            frm.ShowDialog();

        }
    }
}
