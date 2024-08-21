namespace Servicios_Streaming.Vistas
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            PnContenedor = new Panel();
            splitContainer1 = new SplitContainer();
            DtUsuarios = new DataGridView();
            DtTpoServicio = new DataGridView();
            panel5 = new Panel();
            label4 = new Label();
            PnNew = new Panel();
            label3 = new Label();
            BtnGuardar = new Controles.RJButton();
            TxtNombre = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            TxtBuscar = new TextBox();
            panel3 = new Panel();
            BtnAddNew = new Controles.RJButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtTpoServicio).BeginInit();
            panel5.SuspendLayout();
            PnNew.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2645, 148);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Light", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 48, 57);
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(242, 65);
            label1.TabIndex = 2;
            label1.Text = "Usuarios";
            // 
            // panel2
            // 
            panel2.Controls.Add(PnContenedor);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 148);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(40, 0, 40, 100);
            panel2.Size = new Size(2645, 1049);
            panel2.TabIndex = 5;
            // 
            // PnContenedor
            // 
            PnContenedor.BackColor = Color.White;
            PnContenedor.Controls.Add(splitContainer1);
            PnContenedor.Controls.Add(PnNew);
            PnContenedor.Dock = DockStyle.Fill;
            PnContenedor.Location = new Point(40, 258);
            PnContenedor.Name = "PnContenedor";
            PnContenedor.Padding = new Padding(5, 0, 5, 0);
            PnContenedor.Size = new Size(2565, 691);
            PnContenedor.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DtUsuarios);
            splitContainer1.Panel1.Margin = new Padding(0, 0, 0, 10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DtTpoServicio);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Size = new Size(2555, 691);
            splitContainer1.SplitterDistance = 345;
            splitContainer1.TabIndex = 2;
            // 
            // DtUsuarios
            // 
            DtUsuarios.AllowUserToAddRows = false;
            DtUsuarios.AllowUserToDeleteRows = false;
            DtUsuarios.AllowUserToOrderColumns = true;
            DtUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtUsuarios.Dock = DockStyle.Fill;
            DtUsuarios.Location = new Point(0, 0);
            DtUsuarios.Name = "DtUsuarios";
            DtUsuarios.ReadOnly = true;
            DtUsuarios.RowHeadersWidth = 102;
            DtUsuarios.RowTemplate.Height = 49;
            DtUsuarios.Size = new Size(2555, 345);
            DtUsuarios.TabIndex = 0;
            // 
            // DtTpoServicio
            // 
            DtTpoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtTpoServicio.Dock = DockStyle.Fill;
            DtTpoServicio.Location = new Point(0, 0);
            DtTpoServicio.Name = "DtTpoServicio";
            DtTpoServicio.RowHeadersWidth = 102;
            DtTpoServicio.RowTemplate.Height = 49;
            DtTpoServicio.Size = new Size(2555, 342);
            DtTpoServicio.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(2555, 342);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 48, 57);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(356, 48);
            label4.TabIndex = 3;
            label4.Text = "Tipos de Servicios";
            // 
            // PnNew
            // 
            PnNew.Controls.Add(label3);
            PnNew.Controls.Add(BtnGuardar);
            PnNew.Controls.Add(TxtNombre);
            PnNew.Location = new Point(233, 51);
            PnNew.Name = "PnNew";
            PnNew.Size = new Size(282, 170);
            PnNew.TabIndex = 1;
            PnNew.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 48, 57);
            label3.Location = new Point(18, 60);
            label3.Name = "label3";
            label3.Size = new Size(390, 48);
            label3.TabIndex = 4;
            label3.Text = "Nombre del Servicio";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Top;
            BtnGuardar.BackColor = Color.FromArgb(100, 194, 205);
            BtnGuardar.BackgroundColor = Color.FromArgb(100, 194, 205);
            BtnGuardar.BorderColor = Color.PaleVioletRed;
            BtnGuardar.BorderRadius = 10;
            BtnGuardar.BorderSize = 0;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(54, 254);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(284, 100);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextColor = Color.White;
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Top;
            TxtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(-123, 148);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(610, 61);
            TxtNombre.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(TxtBuscar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(40, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(2565, 103);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 48, 57);
            label2.Location = new Point(1925, 29);
            label2.Name = "label2";
            label2.Size = new Size(148, 48);
            label2.TabIndex = 3;
            label2.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBuscar.Location = new Point(2079, 21);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(481, 61);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(BtnAddNew);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(40, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 40, 0);
            panel3.Size = new Size(2565, 155);
            panel3.TabIndex = 0;
            // 
            // BtnAddNew
            // 
            BtnAddNew.BackColor = Color.FromArgb(100, 194, 205);
            BtnAddNew.BackgroundColor = Color.FromArgb(100, 194, 205);
            BtnAddNew.BorderColor = Color.PaleVioletRed;
            BtnAddNew.BorderRadius = 10;
            BtnAddNew.BorderSize = 0;
            BtnAddNew.FlatAppearance.BorderSize = 0;
            BtnAddNew.FlatStyle = FlatStyle.Flat;
            BtnAddNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddNew.ForeColor = Color.White;
            BtnAddNew.Image = (Image)resources.GetObject("BtnAddNew.Image");
            BtnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddNew.Location = new Point(40, 30);
            BtnAddNew.Name = "BtnAddNew";
            BtnAddNew.Size = new Size(375, 100);
            BtnAddNew.TabIndex = 0;
            BtnAddNew.Text = "Crear Usuario";
            BtnAddNew.TextColor = Color.White;
            BtnAddNew.UseVisualStyleBackColor = false;
            BtnAddNew.Click += BtnAddNew_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2645, 1197);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            PnContenedor.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtTpoServicio).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            PnNew.ResumeLayout(false);
            PnNew.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel PnContenedor;
        private SplitContainer splitContainer1;
        private DataGridView DtUsuarios;
        private DataGridView DtTpoServicio;
        private Panel panel5;
        private Label label4;
        private Panel PnNew;
        private Label label3;
        private Controles.RJButton BtnGuardar;
        private TextBox TxtNombre;
        private Panel panel4;
        private Label label2;
        private TextBox TxtBuscar;
        private Panel panel3;
        private Controles.RJButton BtnAddNew;
        private System.Windows.Forms.Timer timer1;
    }
}