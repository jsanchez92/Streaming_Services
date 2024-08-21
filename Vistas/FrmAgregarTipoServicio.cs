using Servicios_Streaming.Controlador;
using Servicios_Streaming.Modelos;
using System;
//using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Streaming.Vistas
{
    public partial class FrmAgregarTipoServicio : Form
    {
        public FrmAgregarTipoServicio()
        {
            InitializeComponent();
            this.BackColor = Variables.formBackColor;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void FrmAgregarTipoServicio_Load(object sender, EventArgs e)
        {
            cargarServicios();
            AyudaUsuario();
        }

        void AyudaUsuario()
        {
            TtMensaje.IsBalloon = true;
            TtMensaje.SetToolTip(CmbServicio, "Establece el servicio.");
            TtMensaje.SetToolTip(cmbTipoServicio, "Establece el tipo servicio.");
            TtMensaje.SetToolTip(TxtCosto, "Establece el costo por servicio.");
            TtMensaje.SetToolTip(TxtCantDis, "Establece el numero de dispositivos por servicio.");
        }
        void cargarServicios()
        {
            CmbServicio.DataSource = new CServicios().Buscar("");
            CmbServicio.ValueMember = "Id";
            CmbServicio.DisplayMember = "Nombre";
            CmbServicio.Refresh();

            if (cmbTipoServicio.Items.Count > 0)
            {
                cmbTipoServicio.SelectedIndex = 0; // Selecciona el primer ítem para evitar que SelectedValue sea null
            }
        }

        bool Validar()
        {
            bool rpt = false;
            try
            {
                EpError.Clear();
                if (CmbServicio.SelectedValue == null) { EpError.SetError(CmbServicio, "El servicio es requerido."); rpt = false;}
                if (cmbTipoServicio.Text == string.Empty) { EpError.SetError(cmbTipoServicio, "El tipo de servicio es requerido."); rpt = false; }
                if (TxtCosto.Text == string.Empty ) { EpError.SetError(TxtCosto, "El Costo es requerido."); rpt = false; }
                if (TxtCantDis.Value == 0) { EpError.SetError(TxtCantDis, "Como mínimo se requiere un dispositivo"); rpt = false; }

                if(CmbServicio.SelectedValue != null && cmbTipoServicio.Text != string.Empty && TxtCosto.Text != string.Empty && TxtCantDis.Value > 0)
                {
                    rpt = true;
                    EpError.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return rpt;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                MTipoServicio tipoServicio = new MTipoServicio
                {
                    ServiciosID = Convert.ToInt32( CmbServicio.SelectedValue),
                    Tipo = cmbTipoServicio.Text,
                    Costo = Convert.ToInt32(TxtCosto.Text),
                    Cant_Dispositivos = Convert.ToInt32(TxtCantDis.Value)
                };
           
                string rpt = new CTipoServicio().Insertar(tipoServicio);
                if (rpt.Equals("Ok"))
                {
                    MessageBox.Show("Registro Insertado Exitosamente.");
                    FrmServicios.BusquedaExterna();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(rpt);
                }
            }
        }

        private void cmbTipoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true    ;
        }

        private void CmbServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }
    }
}
