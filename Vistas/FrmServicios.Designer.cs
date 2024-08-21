namespace Servicios_Streaming.Vistas
{
    partial class FrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            PnContenedor = new Panel();
            PnNew = new Panel();
            BtnCancelar = new Controles.RJButton();
            label3 = new Label();
            BtnGuardar = new Controles.RJButton();
            TxtNombre = new TextBox();
            splitContainer1 = new SplitContainer();
            DtServicios = new DataGridView();
            MenuPrincipal = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem1 = new ToolStripMenuItem();
            refrescarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            DtTpoServicio = new DataGridView();
            MenuAgregarTipos = new ContextMenuStrip(components);
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            agregarNuevoToolStripMenuItem = new ToolStripMenuItem();
            panel5 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            TxtBuscar = new TextBox();
            panel3 = new Panel();
            BtnAddNew = new Controles.RJButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PnContenedor.SuspendLayout();
            PnNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtServicios).BeginInit();
            MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTpoServicio).BeginInit();
            MenuAgregarTipos.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Light", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 48, 57);
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(246, 65);
            label1.TabIndex = 2;
            label1.Text = "Servicios";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2165, 148);
            panel1.TabIndex = 3;
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
            panel2.Size = new Size(2165, 1127);
            panel2.TabIndex = 4;
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
            PnContenedor.Size = new Size(2085, 769);
            PnContenedor.TabIndex = 2;
            // 
            // PnNew
            // 
            PnNew.Controls.Add(BtnCancelar);
            PnNew.Controls.Add(label3);
            PnNew.Controls.Add(BtnGuardar);
            PnNew.Controls.Add(TxtNombre);
            PnNew.Location = new Point(233, 51);
            PnNew.Name = "PnNew";
            PnNew.Size = new Size(1611, 471);
            PnNew.TabIndex = 1;
            PnNew.Visible = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Top;
            BtnCancelar.BackColor = Color.PaleVioletRed;
            BtnCancelar.BackgroundColor = Color.PaleVioletRed;
            BtnCancelar.BorderColor = Color.PaleVioletRed;
            BtnCancelar.BorderRadius = 10;
            BtnCancelar.BorderSize = 0;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(816, 254);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(284, 100);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextColor = Color.White;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 48, 57);
            label3.Location = new Point(641, 60);
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
            BtnGuardar.Location = new Point(520, 254);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(284, 100);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextColor = Color.White;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Top;
            TxtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(500, 148);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(610, 61);
            TxtNombre.TabIndex = 1;
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
            splitContainer1.Panel1.Controls.Add(DtServicios);
            splitContainer1.Panel1.Margin = new Padding(0, 0, 0, 10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DtTpoServicio);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Size = new Size(2075, 769);
            splitContainer1.SplitterDistance = 384;
            splitContainer1.TabIndex = 2;
            // 
            // DtServicios
            // 
            DtServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtServicios.ContextMenuStrip = MenuPrincipal;
            DtServicios.Dock = DockStyle.Fill;
            DtServicios.Location = new Point(0, 0);
            DtServicios.Name = "DtServicios";
            DtServicios.RowHeadersWidth = 102;
            DtServicios.RowTemplate.Height = 49;
            DtServicios.Size = new Size(2075, 384);
            DtServicios.TabIndex = 0;
            DtServicios.CellClick += DtServicios_CellClick;
            DtServicios.SelectionChanged += DtServicios_SelectionChanged;
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.ImageScalingSize = new Size(40, 40);
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, actualizarToolStripMenuItem1, refrescarToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(217, 202);
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(216, 48);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem1
            // 
            actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            actualizarToolStripMenuItem1.Size = new Size(216, 48);
            actualizarToolStripMenuItem1.Text = "Editar";
            actualizarToolStripMenuItem1.Click += actualizarToolStripMenuItem1_Click;
            // 
            // refrescarToolStripMenuItem
            // 
            refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            refrescarToolStripMenuItem.Size = new Size(216, 48);
            refrescarToolStripMenuItem.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(216, 48);
            salirToolStripMenuItem.Text = "Salir.";
            // 
            // DtTpoServicio
            // 
            DtTpoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtTpoServicio.ContextMenuStrip = MenuAgregarTipos;
            DtTpoServicio.Dock = DockStyle.Fill;
            DtTpoServicio.Location = new Point(0, 67);
            DtTpoServicio.Name = "DtTpoServicio";
            DtTpoServicio.RowHeadersWidth = 102;
            DtTpoServicio.RowTemplate.Height = 49;
            DtTpoServicio.Size = new Size(2075, 314);
            DtTpoServicio.TabIndex = 5;
            // 
            // MenuAgregarTipos
            // 
            MenuAgregarTipos.ImageScalingSize = new Size(40, 40);
            MenuAgregarTipos.Items.AddRange(new ToolStripItem[] { actualizarToolStripMenuItem, agregarNuevoToolStripMenuItem });
            MenuAgregarTipos.Name = "MenuAgregarTipos";
            MenuAgregarTipos.Size = new Size(298, 100);
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(297, 48);
            actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            agregarNuevoToolStripMenuItem.Size = new Size(297, 48);
            agregarNuevoToolStripMenuItem.Text = "Agregar Nuevo";
            agregarNuevoToolStripMenuItem.Click += agregarNuevoToolStripMenuItem_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(2075, 67);
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(TxtBuscar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(40, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(2085, 103);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 48, 57);
            label2.Location = new Point(1541, 34);
            label2.Name = "label2";
            label2.Size = new Size(148, 48);
            label2.TabIndex = 3;
            label2.Text = "Buscar";
            label2.Click += label2_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBuscar.Location = new Point(1723, 21);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(330, 61);
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
            panel3.Size = new Size(2085, 155);
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
            BtnAddNew.Text = "Crear Servicio";
            BtnAddNew.TextColor = Color.White;
            BtnAddNew.UseVisualStyleBackColor = false;
            BtnAddNew.Click += BtnAddNew_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "MenuAgregarTipos";
            contextMenuStrip1.Size = new Size(298, 100);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(297, 48);
            toolStripMenuItem1.Text = "Actualizar";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(297, 48);
            toolStripMenuItem2.Text = "Agregar Nuevo";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(40, 40);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4 });
            contextMenuStrip2.Name = "MenuAgregarTipos";
            contextMenuStrip2.Size = new Size(298, 100);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(297, 48);
            toolStripMenuItem3.Text = "Actualizar";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(297, 48);
            toolStripMenuItem4.Text = "Agregar Nuevo";
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2165, 1275);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmServicios";
            Text = "FrmServicios";
            WindowState = FormWindowState.Maximized;
            Load += FrmServicios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            PnContenedor.ResumeLayout(false);
            PnNew.ResumeLayout(false);
            PnNew.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtServicios).EndInit();
            MenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTpoServicio).EndInit();
            MenuAgregarTipos.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel PnContenedor;
        private Controles.RJButton BtnAddNew;
        private DataGridView DtServicios;
        private Label label2;
        private TextBox TxtBuscar;
        private Panel PnNew;
        private Controles.RJButton BtnGuardar;
        private TextBox TxtNombre;
        private Label label3;
        private SplitContainer splitContainer1;
        private Panel panel5;
        private Label label4;
        private DataGridView DtTpoServicio;
        private ContextMenuStrip MenuAgregarTipos;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip MenuPrincipal;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem1;
        private ToolStripMenuItem refrescarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Controles.RJButton BtnCancelar;
    }
}