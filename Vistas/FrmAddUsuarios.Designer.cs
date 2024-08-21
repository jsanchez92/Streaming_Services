namespace Servicios_Streaming.Vistas
{
    partial class FrmAddUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUsuarios));
            BtnGuardar = new Controles.RJButton();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            TxtTelefono = new TextBox();
            label2 = new Label();
            TxtId = new TextBox();
            BtnCancelar = new Controles.RJButton();
            TxtApellidos = new TextBox();
            TxtNombre = new TextBox();
            TxtDireccion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TxtEmail = new TextBox();
            TxtUser = new TextBox();
            label4 = new Label();
            label8 = new Label();
            TxtPass = new TextBox();
            TtMensaje = new ToolTip(components);
            EpError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)EpError).BeginInit();
            SuspendLayout();
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
            BtnGuardar.Location = new Point(441, 867);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(287, 100);
            BtnGuardar.TabIndex = 37;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextColor = Color.White;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(44, 48, 57);
            label5.Location = new Point(516, 250);
            label5.Name = "label5";
            label5.Size = new Size(188, 48);
            label5.TabIndex = 22;
            label5.Text = "Nombres";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 48, 57);
            label3.Location = new Point(496, 322);
            label3.Name = "label3";
            label3.Size = new Size(197, 48);
            label3.TabIndex = 23;
            label3.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 48, 57);
            label1.Location = new Point(516, 391);
            label1.Name = "label1";
            label1.Size = new Size(189, 48);
            label1.TabIndex = 21;
            label1.Text = "Telefono:";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Anchor = AnchorStyles.None;
            TxtTelefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTelefono.Location = new Point(734, 391);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(330, 53);
            TxtTelefono.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 48, 57);
            label2.Location = new Point(663, 169);
            label2.Name = "label2";
            label2.Size = new Size(64, 48);
            label2.TabIndex = 19;
            label2.Text = "Id:";
            // 
            // TxtId
            // 
            TxtId.Anchor = AnchorStyles.None;
            TxtId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtId.Location = new Point(734, 167);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(330, 53);
            TxtId.TabIndex = 17;
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
            BtnCancelar.Location = new Point(757, 867);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(307, 100);
            BtnCancelar.TabIndex = 38;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextColor = Color.White;
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Anchor = AnchorStyles.None;
            TxtApellidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApellidos.Location = new Point(734, 317);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(330, 53);
            TxtApellidos.TabIndex = 31;
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.None;
            TxtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(734, 245);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(330, 53);
            TxtNombre.TabIndex = 30;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Anchor = AnchorStyles.None;
            TxtDireccion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDireccion.Location = new Point(734, 461);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(626, 53);
            TxtDireccion.TabIndex = 33;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(44, 48, 57);
            label6.Location = new Point(503, 461);
            label6.Name = "label6";
            label6.Size = new Size(202, 48);
            label6.TabIndex = 33;
            label6.Text = "Direccion:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(44, 48, 57);
            label7.Location = new Point(580, 537);
            label7.Name = "label7";
            label7.Size = new Size(131, 48);
            label7.TabIndex = 32;
            label7.Text = "Email:";
            // 
            // TxtEmail
            // 
            TxtEmail.Anchor = AnchorStyles.None;
            TxtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(734, 535);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(330, 53);
            TxtEmail.TabIndex = 34;
            // 
            // TxtUser
            // 
            TxtUser.Anchor = AnchorStyles.None;
            TxtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUser.Location = new Point(734, 616);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(330, 53);
            TxtUser.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 48, 57);
            label4.Location = new Point(580, 630);
            label4.Name = "label4";
            label4.Size = new Size(113, 48);
            label4.TabIndex = 37;
            label4.Text = "User:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(44, 48, 57);
            label8.Location = new Point(483, 692);
            label8.Name = "label8";
            label8.Size = new Size(210, 48);
            label8.TabIndex = 36;
            label8.Text = "Password:";
            // 
            // TxtPass
            // 
            TxtPass.Anchor = AnchorStyles.None;
            TxtPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPass.Location = new Point(734, 690);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(330, 53);
            TxtPass.TabIndex = 36;
            // 
            // EpError
            // 
            EpError.ContainerControl = this;
            // 
            // FrmAddUsuarios
            // 
            AcceptButton = BtnGuardar;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancelar;
            ClientSize = new Size(1522, 1240);
            Controls.Add(TxtUser);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(TxtPass);
            Controls.Add(TxtDireccion);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(TxtEmail);
            Controls.Add(TxtNombre);
            Controls.Add(TxtApellidos);
            Controls.Add(BtnGuardar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(TxtTelefono);
            Controls.Add(label2);
            Controls.Add(TxtId);
            Controls.Add(BtnCancelar);
            Name = "FrmAddUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddUsuarios";
            Load += FrmAddUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)EpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.RJButton BtnGuardar;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox TxtTelefono;
        private Label label2;
        private TextBox TxtId;
        private Controles.RJButton BtnCancelar;
        private TextBox TxtApellidos;
        private TextBox TxtNombre;
        private TextBox TxtDireccion;
        private Label label6;
        private Label label7;
        private TextBox TxtEmail;
        private TextBox TxtUser;
        private Label label4;
        private Label label8;
        private TextBox TxtPass;
        private ToolTip TtMensaje;
        private ErrorProvider EpError;
    }
}