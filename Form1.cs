namespace Servicios_Streaming
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            NavBar.BackColor = Modelos.Variables.navBackColor;
            NavBarLogo.BackColor = Modelos.Variables.navLogoBackColor;
            TitleBar.BackColor = Modelos.Variables.navTitleBackColor;
            PnContenedor.BackColor = Modelos.Variables.formBackColor;
        }
        void AbrirFormEnPanel(Form frm)
        {
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

            }
            //recorremos los controles del formulario
            //y si existe el formulario enviado lo mostramos
            foreach (Control control in PnContenedor.Controls)
            {
                if (control is Form existingForm)
                {
                    if (existingForm.GetType() == frm.GetType())
                    {
                        existingForm.BringToFront(); // trae el form al frente
                        return; //finaliza el proceso
                    }
                }
            }
            // A;ado el formulario al control
            PnContenedor.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vistas.FrmDashboard());
            ActivarBoton(BtnDash);
        }

        private void BtnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vistas.FrmServicios());
            ActivarBoton(BtnServicios);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vistas.FrmUsuarios());
            ActivarBoton(BtnUsuarios);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void ActivarBoton(Control btn)
        {
            foreach (Control control in PnBotones.Controls)
            {
                control.BackColor = Color.Transparent;
            }
            btn.BackColor = Modelos.Variables.buttonActiveBackColor;
        }

        private void BtnClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vistas.FrmClientes());
            ActivarBoton(BtnUsuarios);
        }
    }
}
