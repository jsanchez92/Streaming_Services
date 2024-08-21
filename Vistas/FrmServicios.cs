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
        bool IsNuevo = false;
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
            IsNuevo = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string r = "";
            MServicio obj = new MServicio
            {
                Id = IsNuevo ? 0 : IdServicio,
                Nombre = TxtNombre.Text.Trim()
            };
            if (IsNuevo)
            {
                r = new Controlador.CServicios().Add(obj);
            }
            else
            {
                r = new Controlador.CServicios().Update(obj);
            }

            if (r.Equals("Ok"))
            {
                Utils.Mensaje(IsNuevo ? "Registro Insertado Correctamente." : "Registro Actualizado con éxito.");
                PnNew.Visible = false;
                TxtNombre.Clear();
                CargarDatos("");
                IsNuevo = false;
            }
            else
            {
                Utils.Mensaje(r, true);
            }
        }


        private void DtServicios_SelectionChanged(object sender, EventArgs e)
        {
            BuscarTipoServicio();
        }

        void BuscarTipoServicio()
        {
            try
            {
                if (DtServicios.Rows.Count > 0)
                {
                    IdServicio = Convert.ToInt32(DtServicios.CurrentRow.Cells["ID"].Value);

                    DtTpoServicio.DataSource = new Controlador.CTipoServicio().Buscar(IdServicio);
                    DtTpoServicio.Refresh();
                }
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
            BuscarTipoServicio();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAddNew_Click(sender, e);
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BtnAddNew_Click(sender, e);
            TxtNombre.Text = DtServicios.CurrentRow.Cells[1].Value.ToString();
            IsNuevo = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PnNew.Visible = false;
            PnNew.Dock = DockStyle.Fill;
            IsNuevo = false;
        }
    }
}
