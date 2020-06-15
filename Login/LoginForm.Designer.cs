namespace Login
{
    partial class LoginForm
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
            this.InicioDeSecionLabel = new System.Windows.Forms.Label();
            this.HaOlvidadoLaContraseñaLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // InicioDeSecionLabel
            // 
            this.InicioDeSecionLabel.AutoSize = true;
            this.InicioDeSecionLabel.BackColor = System.Drawing.Color.DimGray;
            this.InicioDeSecionLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioDeSecionLabel.Location = new System.Drawing.Point(261, 9);
            this.InicioDeSecionLabel.Name = "InicioDeSecionLabel";
            this.InicioDeSecionLabel.Size = new System.Drawing.Size(222, 30);
            this.InicioDeSecionLabel.TabIndex = 0;
            this.InicioDeSecionLabel.Text = "Inicio De Secion";
            // 
            // HaOlvidadoLaContraseñaLabel
            // 
            this.HaOlvidadoLaContraseñaLabel.AutoSize = true;
            this.HaOlvidadoLaContraseñaLabel.BackColor = System.Drawing.Color.DimGray;
            this.HaOlvidadoLaContraseñaLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaOlvidadoLaContraseñaLabel.Location = new System.Drawing.Point(254, 330);
            this.HaOlvidadoLaContraseñaLabel.Name = "HaOlvidadoLaContraseñaLabel";
            this.HaOlvidadoLaContraseñaLabel.Size = new System.Drawing.Size(240, 18);
            this.HaOlvidadoLaContraseñaLabel.TabIndex = 1;
            this.HaOlvidadoLaContraseñaLabel.Text = "Ha Olvidado La Contraseña";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UsuarioTextBox.Location = new System.Drawing.Point(257, 80);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(226, 20);
            this.UsuarioTextBox.TabIndex = 2;
            this.UsuarioTextBox.Text = "a";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PasswordTextBox.Location = new System.Drawing.Point(257, 157);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(226, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "123";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(257, 241);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(376, 241);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = global::Login.Properties.Resources.ic_launcher;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(555, 357);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.HaOlvidadoLaContraseñaLabel);
            this.Controls.Add(this.InicioDeSecionLabel);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InicioDeSecionLabel;
        private System.Windows.Forms.Label HaOlvidadoLaContraseñaLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

