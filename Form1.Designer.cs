namespace Servicios_Streaming
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            TitleBar = new Panel();
            NavBarLogo = new Panel();
            LblLogo = new Label();
            NavBar = new Panel();
            panel1 = new Panel();
            PnBotones = new FlowLayoutPanel();
            BtnDash = new Controles.RJButton();
            BtnServicios = new Controles.RJButton();
            BtnUsuarios = new Controles.RJButton();
            BtnClientes = new Controles.RJButton();
            panel2 = new Panel();
            BtnConfig = new Controles.RJButton();
            BtnSalir = new Controles.RJButton();
            PnContenedor = new Panel();
            TitleBar.SuspendLayout();
            NavBarLogo.SuspendLayout();
            NavBar.SuspendLayout();
            panel1.SuspendLayout();
            PnBotones.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.Controls.Add(NavBarLogo);
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(2062, 140);
            TitleBar.TabIndex = 0;
            // 
            // NavBarLogo
            // 
            NavBarLogo.BackColor = Color.FromArgb(55, 65, 74);
            NavBarLogo.Controls.Add(LblLogo);
            NavBarLogo.Dock = DockStyle.Left;
            NavBarLogo.Location = new Point(0, 0);
            NavBarLogo.Name = "NavBarLogo";
            NavBarLogo.Size = new Size(335, 140);
            NavBarLogo.TabIndex = 0;
            // 
            // LblLogo
            // 
            LblLogo.AutoSize = true;
            LblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogo.ForeColor = Color.FromArgb(100, 194, 205);
            LblLogo.Location = new Point(37, 19);
            LblLogo.Name = "LblLogo";
            LblLogo.Size = new Size(260, 89);
            LblLogo.TabIndex = 0;
            LblLogo.Text = "Stream";
            // 
            // NavBar
            // 
            NavBar.BackColor = Color.FromArgb(74, 88, 99);
            NavBar.Controls.Add(panel1);
            NavBar.Dock = DockStyle.Left;
            NavBar.Location = new Point(0, 140);
            NavBar.Name = "NavBar";
            NavBar.Padding = new Padding(10, 10, 0, 0);
            NavBar.Size = new Size(335, 1099);
            NavBar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(PnBotones);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 1089);
            panel1.TabIndex = 0;
            // 
            // PnBotones
            // 
            PnBotones.Controls.Add(BtnDash);
            PnBotones.Controls.Add(BtnServicios);
            PnBotones.Controls.Add(BtnUsuarios);
            PnBotones.Controls.Add(BtnClientes);
            PnBotones.Dock = DockStyle.Fill;
            PnBotones.Location = new Point(0, 0);
            PnBotones.Name = "PnBotones";
            PnBotones.Padding = new Padding(20);
            PnBotones.Size = new Size(325, 906);
            PnBotones.TabIndex = 6;
            // 
            // BtnDash
            // 
            BtnDash.BackColor = Color.Transparent;
            BtnDash.BackgroundColor = Color.Transparent;
            BtnDash.BorderColor = Color.PaleVioletRed;
            BtnDash.BorderRadius = 0;
            BtnDash.BorderSize = 0;
            BtnDash.FlatAppearance.BorderSize = 0;
            BtnDash.FlatStyle = FlatStyle.Flat;
            BtnDash.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDash.ForeColor = Color.White;
            BtnDash.Image = (Image)resources.GetObject("BtnDash.Image");
            BtnDash.ImageAlign = ContentAlignment.TopCenter;
            BtnDash.Location = new Point(23, 23);
            BtnDash.Name = "BtnDash";
            BtnDash.Padding = new Padding(8);
            BtnDash.Size = new Size(263, 140);
            BtnDash.TabIndex = 1;
            BtnDash.Text = "Dashboard";
            BtnDash.TextAlign = ContentAlignment.BottomCenter;
            BtnDash.TextColor = Color.White;
            BtnDash.UseVisualStyleBackColor = false;
            BtnDash.Click += BtnDash_Click;
            // 
            // BtnServicios
            // 
            BtnServicios.BackColor = Color.Transparent;
            BtnServicios.BackgroundColor = Color.Transparent;
            BtnServicios.BorderColor = Color.PaleVioletRed;
            BtnServicios.BorderRadius = 0;
            BtnServicios.BorderSize = 0;
            BtnServicios.FlatAppearance.BorderSize = 0;
            BtnServicios.FlatStyle = FlatStyle.Flat;
            BtnServicios.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnServicios.ForeColor = Color.White;
            BtnServicios.Image = (Image)resources.GetObject("BtnServicios.Image");
            BtnServicios.ImageAlign = ContentAlignment.TopCenter;
            BtnServicios.Location = new Point(23, 169);
            BtnServicios.Name = "BtnServicios";
            BtnServicios.Padding = new Padding(8);
            BtnServicios.Size = new Size(263, 140);
            BtnServicios.TabIndex = 2;
            BtnServicios.Text = "Servicios";
            BtnServicios.TextAlign = ContentAlignment.BottomCenter;
            BtnServicios.TextColor = Color.White;
            BtnServicios.UseVisualStyleBackColor = false;
            BtnServicios.Click += BtnServicios_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.Transparent;
            BtnUsuarios.BackgroundColor = Color.Transparent;
            BtnUsuarios.BorderColor = Color.PaleVioletRed;
            BtnUsuarios.BorderRadius = 0;
            BtnUsuarios.BorderSize = 0;
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUsuarios.ForeColor = Color.White;
            BtnUsuarios.Image = (Image)resources.GetObject("BtnUsuarios.Image");
            BtnUsuarios.ImageAlign = ContentAlignment.TopCenter;
            BtnUsuarios.Location = new Point(23, 315);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Padding = new Padding(8);
            BtnUsuarios.Size = new Size(263, 140);
            BtnUsuarios.TabIndex = 3;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            BtnUsuarios.TextColor = Color.White;
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnClientes_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.BackColor = Color.Transparent;
            BtnClientes.BackgroundColor = Color.Transparent;
            BtnClientes.BorderColor = Color.PaleVioletRed;
            BtnClientes.BorderRadius = 0;
            BtnClientes.BorderSize = 0;
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClientes.ForeColor = Color.White;
            BtnClientes.Image = (Image)resources.GetObject("BtnClientes.Image");
            BtnClientes.ImageAlign = ContentAlignment.TopCenter;
            BtnClientes.Location = new Point(23, 461);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Padding = new Padding(8);
            BtnClientes.Size = new Size(263, 140);
            BtnClientes.TabIndex = 4;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.BottomCenter;
            BtnClientes.TextColor = Color.White;
            BtnClientes.UseVisualStyleBackColor = false;
            BtnClientes.Click += BtnClientes_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnConfig);
            panel2.Controls.Add(BtnSalir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 906);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 183);
            panel2.TabIndex = 5;
            // 
            // BtnConfig
            // 
            BtnConfig.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnConfig.BackColor = Color.Transparent;
            BtnConfig.BackgroundColor = Color.Transparent;
            BtnConfig.BorderColor = Color.PaleVioletRed;
            BtnConfig.BorderRadius = 0;
            BtnConfig.BorderSize = 0;
            BtnConfig.FlatAppearance.BorderSize = 0;
            BtnConfig.FlatStyle = FlatStyle.Flat;
            BtnConfig.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfig.ForeColor = Color.White;
            BtnConfig.Image = (Image)resources.GetObject("BtnConfig.Image");
            BtnConfig.ImageAlign = ContentAlignment.TopCenter;
            BtnConfig.Location = new Point(172, 47);
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Padding = new Padding(8);
            BtnConfig.Size = new Size(98, 93);
            BtnConfig.TabIndex = 5;
            BtnConfig.TextAlign = ContentAlignment.BottomCenter;
            BtnConfig.TextColor = Color.White;
            BtnConfig.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalir.BackColor = Color.DimGray;
            BtnSalir.BackgroundColor = Color.DimGray;
            BtnSalir.BorderColor = Color.PaleVioletRed;
            BtnSalir.BorderRadius = 35;
            BtnSalir.BorderSize = 0;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.ImageAlign = ContentAlignment.TopCenter;
            BtnSalir.Location = new Point(24, 47);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Padding = new Padding(8);
            BtnSalir.Size = new Size(98, 93);
            BtnSalir.TabIndex = 4;
            BtnSalir.TextAlign = ContentAlignment.BottomCenter;
            BtnSalir.TextColor = Color.White;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // PnContenedor
            // 
            PnContenedor.Dock = DockStyle.Fill;
            PnContenedor.Location = new Point(335, 140);
            PnContenedor.Name = "PnContenedor";
            PnContenedor.Size = new Size(1727, 1099);
            PnContenedor.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2062, 1239);
            Controls.Add(PnContenedor);
            Controls.Add(NavBar);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            TitleBar.ResumeLayout(false);
            NavBarLogo.ResumeLayout(false);
            NavBarLogo.PerformLayout();
            NavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            PnBotones.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TitleBar;
        private Panel NavBarLogo;
        private Panel PnContenedor;
        private Controles.RJButton BtnDash;
        private Controles.RJButton BtnServicios;
        private Label LblLogo;
        private Controles.RJButton BtnUsuarios;
        private Panel panel1;
        private Panel NavBar;
        private Panel panel2;
        private Controles.RJButton BtnConfig;
        private Controles.RJButton BtnSalir;
        private FlowLayoutPanel PnBotones;
        private Controles.RJButton BtnClientes;
    }
}
