namespace Servicios_Streaming.Vistas
{
    partial class FrmAgregarTipoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarTipoServicio));
            label2 = new Label();
            TxtId = new TextBox();
            BtnCancelar = new Controles.RJButton();
            label1 = new Label();
            TxtCosto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CmbServicio = new ComboBox();
            label5 = new Label();
            cmbTipoServicio = new ComboBox();
            TxtCantDis = new NumericUpDown();
            BtnGuardar = new Controles.RJButton();
            EpError = new ErrorProvider(components);
            TtMensaje = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)TxtCantDis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpError).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 48, 57);
            label2.Location = new Point(494, 231);
            label2.Name = "label2";
            label2.Size = new Size(64, 48);
            label2.TabIndex = 6;
            label2.Text = "Id:";
            // 
            // TxtId
            // 
            TxtId.Anchor = AnchorStyles.None;
            TxtId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtId.Location = new Point(565, 229);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(330, 53);
            TxtId.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(100, 194, 205);
            BtnCancelar.BackgroundColor = Color.FromArgb(100, 194, 205);
            BtnCancelar.BorderColor = Color.PaleVioletRed;
            BtnCancelar.BorderRadius = 10;
            BtnCancelar.BorderSize = 0;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(831, 669);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(271, 100);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextColor = Color.White;
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 48, 57);
            label1.Location = new Point(421, 453);
            label1.Name = "label1";
            label1.Size = new Size(137, 48);
            label1.TabIndex = 8;
            label1.Text = "Costo:";
            // 
            // TxtCosto
            // 
            TxtCosto.Anchor = AnchorStyles.None;
            TxtCosto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCosto.Location = new Point(565, 453);
            TxtCosto.Name = "TxtCosto";
            TxtCosto.Size = new Size(330, 53);
            TxtCosto.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 48, 57);
            label3.Location = new Point(292, 384);
            label3.Name = "label3";
            label3.Size = new Size(267, 48);
            label3.TabIndex = 10;
            label3.Text = "Tipo Servicio:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 48, 57);
            label4.Location = new Point(75, 534);
            label4.Name = "label4";
            label4.Size = new Size(483, 48);
            label4.TabIndex = 12;
            label4.Text = "Cantidad de Dispositivos:";
            // 
            // CmbServicio
            // 
            CmbServicio.Anchor = AnchorStyles.None;
            CmbServicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CmbServicio.FormattingEnabled = true;
            CmbServicio.Location = new Point(562, 306);
            CmbServicio.Name = "CmbServicio";
            CmbServicio.Size = new Size(540, 54);
            CmbServicio.TabIndex = 13;
            CmbServicio.KeyPress += CmbServicio_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(44, 48, 57);
            label5.Location = new Point(383, 307);
            label5.Name = "label5";
            label5.Size = new Size(175, 48);
            label5.TabIndex = 10;
            label5.Text = "Servicio:";
            // 
            // cmbTipoServicio
            // 
            cmbTipoServicio.Anchor = AnchorStyles.None;
            cmbTipoServicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoServicio.FormattingEnabled = true;
            cmbTipoServicio.Items.AddRange(new object[] { "Mensual", "Trimestral", "Semestral", "Anual" });
            cmbTipoServicio.Location = new Point(562, 386);
            cmbTipoServicio.Name = "cmbTipoServicio";
            cmbTipoServicio.Size = new Size(540, 54);
            cmbTipoServicio.TabIndex = 14;
            cmbTipoServicio.KeyPress += cmbTipoServicio_KeyPress;
            // 
            // TxtCantDis
            // 
            TxtCantDis.Anchor = AnchorStyles.None;
            TxtCantDis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCantDis.Location = new Point(562, 537);
            TxtCantDis.Name = "TxtCantDis";
            TxtCantDis.Size = new Size(215, 53);
            TxtCantDis.TabIndex = 15;
            // 
            // BtnGuardar
            // 
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
            BtnGuardar.Location = new Point(515, 669);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(287, 100);
            BtnGuardar.TabIndex = 16;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextColor = Color.White;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // EpError
            // 
            EpError.ContainerControl = this;
            // 
            // TtMensaje
            // 
            TtMensaje.ShowAlways = true;
            // 
            // FrmAgregarTipoServicio
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 854);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtCantDis);
            Controls.Add(cmbTipoServicio);
            Controls.Add(CmbServicio);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(TxtCosto);
            Controls.Add(label2);
            Controls.Add(TxtId);
            Controls.Add(BtnCancelar);
            Name = "FrmAgregarTipoServicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarTipoServicio";
            Load += FrmAgregarTipoServicio_Load;
            ((System.ComponentModel.ISupportInitialize)TxtCantDis).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox TxtId;
        private Controles.RJButton BtnCancelar;
        private Label label1;
        private TextBox TxtCosto;
        private Label label3;
        private Label label4;
        private ComboBox CmbServicio;
        private Label label5;
        private ComboBox cmbTipoServicio;
        private NumericUpDown TxtCantDis;
        private Controles.RJButton BtnGuardar;
        private ErrorProvider EpError;
        private ToolTip TtMensaje;
    }
}