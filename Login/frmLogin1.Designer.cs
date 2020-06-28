namespace Login
{
    partial class frmLogin1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin1));
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IniciodeseccionLabel = new System.Windows.Forms.Label();
            this.HaOlvidadoLaContraseñeaLabel = new System.Windows.Forms.Label();
            this.CerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ClaveextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 237);
            this.logoPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Login.Properties.Resources._256x256_login;
            this.pictureBox1.Location = new System.Drawing.Point(52, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // IniciodeseccionLabel
            // 
            this.IniciodeseccionLabel.AutoSize = true;
            this.IniciodeseccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciodeseccionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.IniciodeseccionLabel.Location = new System.Drawing.Point(374, 3);
            this.IniciodeseccionLabel.Name = "IniciodeseccionLabel";
            this.IniciodeseccionLabel.Size = new System.Drawing.Size(234, 32);
            this.IniciodeseccionLabel.TabIndex = 1;
            this.IniciodeseccionLabel.Text = "Inicio De Sección";
            this.IniciodeseccionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IniciodeseccionLabel_MouseDown);
            // 
            // HaOlvidadoLaContraseñeaLabel
            // 
            this.HaOlvidadoLaContraseñeaLabel.AutoSize = true;
            this.HaOlvidadoLaContraseñeaLabel.BackColor = System.Drawing.Color.Transparent;
            this.HaOlvidadoLaContraseñeaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaOlvidadoLaContraseñeaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.HaOlvidadoLaContraseñeaLabel.Location = new System.Drawing.Point(385, 208);
            this.HaOlvidadoLaContraseñeaLabel.Name = "HaOlvidadoLaContraseñeaLabel";
            this.HaOlvidadoLaContraseñeaLabel.Size = new System.Drawing.Size(222, 20);
            this.HaOlvidadoLaContraseñeaLabel.TabIndex = 2;
            this.HaOlvidadoLaContraseñeaLabel.Text = "¿Ha Olvidado La Contraseña?";
            this.HaOlvidadoLaContraseñeaLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HaOlvidadoLaContraseñeaLabel_MouseDown);
            // 
            // CerrarPictureBox
            // 
            this.CerrarPictureBox.Image = global::Login.Properties.Resources._20x20_cerrar;
            this.CerrarPictureBox.Location = new System.Drawing.Point(675, 7);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(23, 28);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 4;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // MinimizarPictureBox
            // 
            this.MinimizarPictureBox.Image = global::Login.Properties.Resources.minimizar20x20;
            this.MinimizarPictureBox.Location = new System.Drawing.Point(614, 7);
            this.MinimizarPictureBox.Name = "MinimizarPictureBox";
            this.MinimizarPictureBox.Size = new System.Drawing.Size(23, 28);
            this.MinimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarPictureBox.TabIndex = 3;
            this.MinimizarPictureBox.TabStop = false;
            this.MinimizarPictureBox.Click += new System.EventHandler(this.MinimizarPictureBox_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Image = global::Login.Properties.Resources._32x32cerrar2;
            this.cancelarButton.Location = new System.Drawing.Point(511, 145);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(45, 49);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.TabStop = false;
            this.cancelarButton.Text = ".......";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.FlatAppearance.BorderSize = 0;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Image = global::Login.Properties.Resources.aceptarinicio_32x322;
            this.aceptarButton.Location = new System.Drawing.Point(389, 145);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(45, 49);
            this.aceptarButton.TabIndex = 0;
            this.aceptarButton.Text = ".......";
            this.aceptarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.UsuarioTextBox.Location = new System.Drawing.Point(290, 55);
            this.UsuarioTextBox.Multiline = true;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(380, 27);
            this.UsuarioTextBox.TabIndex = 5;
            this.UsuarioTextBox.Text = "a";
            this.UsuarioTextBox.Enter += new System.EventHandler(this.UsuarioTextBox_Enter);
            this.UsuarioTextBox.Leave += new System.EventHandler(this.UsuarioTextBox_Leave);
            // 
            // ClaveextBox
            // 
            this.ClaveextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClaveextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ClaveextBox.Location = new System.Drawing.Point(290, 110);
            this.ClaveextBox.Multiline = true;
            this.ClaveextBox.Name = "ClaveextBox";
            this.ClaveextBox.PasswordChar = '*';
            this.ClaveextBox.Size = new System.Drawing.Size(380, 27);
            this.ClaveextBox.TabIndex = 6;
            this.ClaveextBox.Text = "123";
            this.ClaveextBox.Enter += new System.EventHandler(this.ClaveextBox_Enter);
            this.ClaveextBox.Leave += new System.EventHandler(this.ClaveextBox_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(710, 237);
            this.Controls.Add(this.ClaveextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.MinimizarPictureBox);
            this.Controls.Add(this.HaOlvidadoLaContraseñeaLabel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.IniciodeseccionLabel);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin1";
            this.Load += new System.EventHandler(this.frmLogin1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin1_MouseDown);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IniciodeseccionLabel;
        private System.Windows.Forms.Label HaOlvidadoLaContraseñeaLabel;
        private System.Windows.Forms.PictureBox MinimizarPictureBox;
        private System.Windows.Forms.PictureBox CerrarPictureBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ClaveextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}