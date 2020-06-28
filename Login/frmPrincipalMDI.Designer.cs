namespace Login
{
    partial class frmPrincipalMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalMDI));
            this.pricipalPanel = new System.Windows.Forms.Panel();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.tituloPanel = new System.Windows.Forms.Panel();
            this.minimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.restaurarPictureBox = new System.Windows.Forms.PictureBox();
            this.maximizarPictureBox = new System.Windows.Forms.PictureBox();
            this.cerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.slidePictureBox = new System.Windows.Forms.PictureBox();
            this.menuVerticalPanel = new System.Windows.Forms.Panel();
            this.movimientoPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.salidasButton = new System.Windows.Forms.Button();
            this.traladosButton = new System.Windows.Forms.Button();
            this.devolucionesButton = new System.Windows.Forms.Button();
            this.comprasButton = new System.Windows.Forms.Button();
            this.movimientoButton = new System.Windows.Forms.Button();
            this.archivoSubMenuPanel = new System.Windows.Forms.Panel();
            this.cabioClaveButton = new System.Windows.Forms.Button();
            this.cambioUsuarioButton = new System.Windows.Forms.Button();
            this.usuarioButton = new System.Windows.Forms.Button();
            this.tipoDocumentoButton = new System.Windows.Forms.Button();
            this.proveedorButton = new System.Windows.Forms.Button();
            this.productosButton = new System.Windows.Forms.Button();
            this.clienteButton = new System.Windows.Forms.Button();
            this.bodegaButton = new System.Windows.Forms.Button();
            this.servicioButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pricipalPanel.SuspendLayout();
            this.tituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).BeginInit();
            this.menuVerticalPanel.SuspendLayout();
            this.movimientoPanel.SuspendLayout();
            this.archivoSubMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pricipalPanel
            // 
            this.pricipalPanel.Controls.Add(this.contenedorPanel);
            this.pricipalPanel.Controls.Add(this.tituloPanel);
            this.pricipalPanel.Controls.Add(this.menuVerticalPanel);
            this.pricipalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricipalPanel.Location = new System.Drawing.Point(0, 0);
            this.pricipalPanel.Name = "pricipalPanel";
            this.pricipalPanel.Size = new System.Drawing.Size(1330, 650);
            this.pricipalPanel.TabIndex = 0;
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.contenedorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPanel.Location = new System.Drawing.Point(200, 50);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(1130, 600);
            this.contenedorPanel.TabIndex = 2;
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tituloPanel.Controls.Add(this.minimizarPictureBox);
            this.tituloPanel.Controls.Add(this.restaurarPictureBox);
            this.tituloPanel.Controls.Add(this.maximizarPictureBox);
            this.tituloPanel.Controls.Add(this.cerrarPictureBox);
            this.tituloPanel.Controls.Add(this.slidePictureBox);
            this.tituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPanel.Location = new System.Drawing.Point(200, 0);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(1130, 50);
            this.tituloPanel.TabIndex = 1;
            this.tituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloPanel_MouseDown);
            // 
            // minimizarPictureBox
            // 
            this.minimizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarPictureBox.Image = global::Login.Properties.Resources._32x32minimizarColor1;
            this.minimizarPictureBox.Location = new System.Drawing.Point(1010, 12);
            this.minimizarPictureBox.Name = "minimizarPictureBox";
            this.minimizarPictureBox.Size = new System.Drawing.Size(32, 32);
            this.minimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarPictureBox.TabIndex = 4;
            this.minimizarPictureBox.TabStop = false;
            this.minimizarPictureBox.Click += new System.EventHandler(this.minimizarPictureBox_Click);
            // 
            // restaurarPictureBox
            // 
            this.restaurarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurarPictureBox.Image = global::Login.Properties.Resources.miximed_32x32;
            this.restaurarPictureBox.Location = new System.Drawing.Point(1050, 11);
            this.restaurarPictureBox.Name = "restaurarPictureBox";
            this.restaurarPictureBox.Size = new System.Drawing.Size(32, 32);
            this.restaurarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurarPictureBox.TabIndex = 3;
            this.restaurarPictureBox.TabStop = false;
            this.restaurarPictureBox.Click += new System.EventHandler(this.restaurarPictureBox_Click);
            // 
            // maximizarPictureBox
            // 
            this.maximizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarPictureBox.Image = global::Login.Properties.Resources.restaurar32x32Color;
            this.maximizarPictureBox.Location = new System.Drawing.Point(1050, 11);
            this.maximizarPictureBox.Name = "maximizarPictureBox";
            this.maximizarPictureBox.Size = new System.Drawing.Size(32, 32);
            this.maximizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizarPictureBox.TabIndex = 2;
            this.maximizarPictureBox.TabStop = false;
            // 
            // cerrarPictureBox
            // 
            this.cerrarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarPictureBox.Image = global::Login.Properties.Resources.cerrar32x32Color;
            this.cerrarPictureBox.Location = new System.Drawing.Point(1091, 12);
            this.cerrarPictureBox.Name = "cerrarPictureBox";
            this.cerrarPictureBox.Size = new System.Drawing.Size(32, 32);
            this.cerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarPictureBox.TabIndex = 1;
            this.cerrarPictureBox.TabStop = false;
            // 
            // slidePictureBox
            // 
            this.slidePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidePictureBox.Image = global::Login.Properties.Resources.menu_32x32;
            this.slidePictureBox.Location = new System.Drawing.Point(0, 3);
            this.slidePictureBox.Name = "slidePictureBox";
            this.slidePictureBox.Size = new System.Drawing.Size(58, 50);
            this.slidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slidePictureBox.TabIndex = 0;
            this.slidePictureBox.TabStop = false;
            this.slidePictureBox.Click += new System.EventHandler(this.slidePictureBox_Click);
            // 
            // menuVerticalPanel
            // 
            this.menuVerticalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVerticalPanel.Controls.Add(this.movimientoPanel);
            this.menuVerticalPanel.Controls.Add(this.movimientoButton);
            this.menuVerticalPanel.Controls.Add(this.archivoSubMenuPanel);
            this.menuVerticalPanel.Controls.Add(this.servicioButton);
            this.menuVerticalPanel.Controls.Add(this.logoPanel);
            this.menuVerticalPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVerticalPanel.Location = new System.Drawing.Point(0, 0);
            this.menuVerticalPanel.Name = "menuVerticalPanel";
            this.menuVerticalPanel.Size = new System.Drawing.Size(200, 650);
            this.menuVerticalPanel.TabIndex = 0;
            // 
            // movimientoPanel
            // 
            this.movimientoPanel.Controls.Add(this.button4);
            this.movimientoPanel.Controls.Add(this.button3);
            this.movimientoPanel.Controls.Add(this.button5);
            this.movimientoPanel.Controls.Add(this.button6);
            this.movimientoPanel.Controls.Add(this.salidasButton);
            this.movimientoPanel.Controls.Add(this.traladosButton);
            this.movimientoPanel.Controls.Add(this.devolucionesButton);
            this.movimientoPanel.Controls.Add(this.comprasButton);
            this.movimientoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movimientoPanel.Location = new System.Drawing.Point(0, 405);
            this.movimientoPanel.Name = "movimientoPanel";
            this.movimientoPanel.Size = new System.Drawing.Size(200, 164);
            this.movimientoPanel.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Login.Properties.Resources.salidas20x20;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(0, 788);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Salidas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Login.Properties.Resources.salidas20x20;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 765);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salidas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 742);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Usuario";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 92);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 650);
            this.button6.TabIndex = 4;
            this.button6.Text = "Tipo Documento";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // salidasButton
            // 
            this.salidasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salidasButton.FlatAppearance.BorderSize = 0;
            this.salidasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salidasButton.ForeColor = System.Drawing.Color.White;
            this.salidasButton.Image = global::Login.Properties.Resources.salidas20x20;
            this.salidasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salidasButton.Location = new System.Drawing.Point(0, 69);
            this.salidasButton.Name = "salidasButton";
            this.salidasButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.salidasButton.Size = new System.Drawing.Size(200, 23);
            this.salidasButton.TabIndex = 3;
            this.salidasButton.Text = "Salidas";
            this.salidasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salidasButton.UseVisualStyleBackColor = true;
            // 
            // traladosButton
            // 
            this.traladosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.traladosButton.FlatAppearance.BorderSize = 0;
            this.traladosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traladosButton.ForeColor = System.Drawing.Color.White;
            this.traladosButton.Image = global::Login.Properties.Resources.trasladosNegro20x20;
            this.traladosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.traladosButton.Location = new System.Drawing.Point(0, 46);
            this.traladosButton.Name = "traladosButton";
            this.traladosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.traladosButton.Size = new System.Drawing.Size(200, 23);
            this.traladosButton.TabIndex = 2;
            this.traladosButton.Text = "Traslados";
            this.traladosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traladosButton.UseVisualStyleBackColor = true;
            // 
            // devolucionesButton
            // 
            this.devolucionesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devolucionesButton.FlatAppearance.BorderSize = 0;
            this.devolucionesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devolucionesButton.ForeColor = System.Drawing.Color.White;
            this.devolucionesButton.Image = global::Login.Properties.Resources.devoluciones20x20;
            this.devolucionesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.devolucionesButton.Location = new System.Drawing.Point(0, 23);
            this.devolucionesButton.Name = "devolucionesButton";
            this.devolucionesButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.devolucionesButton.Size = new System.Drawing.Size(200, 23);
            this.devolucionesButton.TabIndex = 1;
            this.devolucionesButton.Text = "Devoluciones";
            this.devolucionesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devolucionesButton.UseVisualStyleBackColor = true;
            // 
            // comprasButton
            // 
            this.comprasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.comprasButton.FlatAppearance.BorderSize = 0;
            this.comprasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprasButton.ForeColor = System.Drawing.Color.White;
            this.comprasButton.Image = global::Login.Properties.Resources.compras_20x20;
            this.comprasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.comprasButton.Location = new System.Drawing.Point(0, 0);
            this.comprasButton.Name = "comprasButton";
            this.comprasButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.comprasButton.Size = new System.Drawing.Size(200, 23);
            this.comprasButton.TabIndex = 0;
            this.comprasButton.Text = "Compras";
            this.comprasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprasButton.UseVisualStyleBackColor = true;
            // 
            // movimientoButton
            // 
            this.movimientoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.movimientoButton.FlatAppearance.BorderSize = 0;
            this.movimientoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movimientoButton.ForeColor = System.Drawing.Color.White;
            this.movimientoButton.Image = global::Login.Properties.Resources.movimientosNegro20x20;
            this.movimientoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.movimientoButton.Location = new System.Drawing.Point(0, 376);
            this.movimientoButton.Name = "movimientoButton";
            this.movimientoButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.movimientoButton.Size = new System.Drawing.Size(200, 29);
            this.movimientoButton.TabIndex = 3;
            this.movimientoButton.Text = "Movimiento";
            this.movimientoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimientoButton.UseVisualStyleBackColor = true;
            // 
            // archivoSubMenuPanel
            // 
            this.archivoSubMenuPanel.Controls.Add(this.cabioClaveButton);
            this.archivoSubMenuPanel.Controls.Add(this.cambioUsuarioButton);
            this.archivoSubMenuPanel.Controls.Add(this.usuarioButton);
            this.archivoSubMenuPanel.Controls.Add(this.tipoDocumentoButton);
            this.archivoSubMenuPanel.Controls.Add(this.proveedorButton);
            this.archivoSubMenuPanel.Controls.Add(this.productosButton);
            this.archivoSubMenuPanel.Controls.Add(this.clienteButton);
            this.archivoSubMenuPanel.Controls.Add(this.bodegaButton);
            this.archivoSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.archivoSubMenuPanel.Location = new System.Drawing.Point(0, 129);
            this.archivoSubMenuPanel.Name = "archivoSubMenuPanel";
            this.archivoSubMenuPanel.Size = new System.Drawing.Size(200, 247);
            this.archivoSubMenuPanel.TabIndex = 2;
            // 
            // cabioClaveButton
            // 
            this.cabioClaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabioClaveButton.FlatAppearance.BorderSize = 0;
            this.cabioClaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cabioClaveButton.ForeColor = System.Drawing.Color.White;
            this.cabioClaveButton.Image = global::Login.Properties.Resources.cambioClave20x20;
            this.cabioClaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cabioClaveButton.Location = new System.Drawing.Point(0, 161);
            this.cabioClaveButton.Name = "cabioClaveButton";
            this.cabioClaveButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cabioClaveButton.Size = new System.Drawing.Size(200, 29);
            this.cabioClaveButton.TabIndex = 7;
            this.cabioClaveButton.Text = "Cambio Clave";
            this.cabioClaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cabioClaveButton.UseVisualStyleBackColor = true;
            this.cabioClaveButton.Click += new System.EventHandler(this.cabioClaveButton_Click);
            // 
            // cambioUsuarioButton
            // 
            this.cambioUsuarioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cambioUsuarioButton.FlatAppearance.BorderSize = 0;
            this.cambioUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambioUsuarioButton.ForeColor = System.Drawing.Color.White;
            this.cambioUsuarioButton.Image = global::Login.Properties.Resources.canbioUsuario20x20;
            this.cambioUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cambioUsuarioButton.Location = new System.Drawing.Point(0, 138);
            this.cambioUsuarioButton.Name = "cambioUsuarioButton";
            this.cambioUsuarioButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cambioUsuarioButton.Size = new System.Drawing.Size(200, 23);
            this.cambioUsuarioButton.TabIndex = 6;
            this.cambioUsuarioButton.Text = "Cambio Usuario";
            this.cambioUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambioUsuarioButton.UseVisualStyleBackColor = true;
            this.cambioUsuarioButton.Click += new System.EventHandler(this.cambioUsuarioButton_Click);
            // 
            // usuarioButton
            // 
            this.usuarioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarioButton.FlatAppearance.BorderSize = 0;
            this.usuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarioButton.ForeColor = System.Drawing.Color.White;
            this.usuarioButton.Image = global::Login.Properties.Resources.usuario20x20;
            this.usuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuarioButton.Location = new System.Drawing.Point(0, 115);
            this.usuarioButton.Name = "usuarioButton";
            this.usuarioButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.usuarioButton.Size = new System.Drawing.Size(200, 23);
            this.usuarioButton.TabIndex = 5;
            this.usuarioButton.Text = "Usuario";
            this.usuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuarioButton.UseVisualStyleBackColor = true;
            this.usuarioButton.Click += new System.EventHandler(this.usuarioButton_Click);
            // 
            // tipoDocumentoButton
            // 
            this.tipoDocumentoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipoDocumentoButton.FlatAppearance.BorderSize = 0;
            this.tipoDocumentoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoDocumentoButton.ForeColor = System.Drawing.Color.White;
            this.tipoDocumentoButton.Image = global::Login.Properties.Resources.tipoDocumentoNegro20x20;
            this.tipoDocumentoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipoDocumentoButton.Location = new System.Drawing.Point(0, 92);
            this.tipoDocumentoButton.Name = "tipoDocumentoButton";
            this.tipoDocumentoButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.tipoDocumentoButton.Size = new System.Drawing.Size(200, 23);
            this.tipoDocumentoButton.TabIndex = 4;
            this.tipoDocumentoButton.Text = "Tipo Documento";
            this.tipoDocumentoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipoDocumentoButton.UseVisualStyleBackColor = true;
            this.tipoDocumentoButton.Click += new System.EventHandler(this.tipoDocumentoButton_Click);
            // 
            // proveedorButton
            // 
            this.proveedorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.proveedorButton.FlatAppearance.BorderSize = 0;
            this.proveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedorButton.ForeColor = System.Drawing.Color.White;
            this.proveedorButton.Image = global::Login.Properties.Resources.provedor20x20;
            this.proveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.proveedorButton.Location = new System.Drawing.Point(0, 69);
            this.proveedorButton.Name = "proveedorButton";
            this.proveedorButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.proveedorButton.Size = new System.Drawing.Size(200, 23);
            this.proveedorButton.TabIndex = 3;
            this.proveedorButton.Text = "Proveedor";
            this.proveedorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedorButton.UseVisualStyleBackColor = true;
            this.proveedorButton.Click += new System.EventHandler(this.proveedorButton_Click);
            // 
            // productosButton
            // 
            this.productosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productosButton.FlatAppearance.BorderSize = 0;
            this.productosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productosButton.ForeColor = System.Drawing.Color.White;
            this.productosButton.Image = global::Login.Properties.Resources.productosNegro20x20;
            this.productosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productosButton.Location = new System.Drawing.Point(0, 46);
            this.productosButton.Name = "productosButton";
            this.productosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.productosButton.Size = new System.Drawing.Size(200, 23);
            this.productosButton.TabIndex = 2;
            this.productosButton.Text = "Productos";
            this.productosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosButton.UseVisualStyleBackColor = true;
            this.productosButton.Click += new System.EventHandler(this.productosButton_Click);
            // 
            // clienteButton
            // 
            this.clienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clienteButton.FlatAppearance.BorderSize = 0;
            this.clienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clienteButton.ForeColor = System.Drawing.Color.White;
            this.clienteButton.Image = global::Login.Properties.Resources.clientesNegro20x20;
            this.clienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clienteButton.Location = new System.Drawing.Point(0, 23);
            this.clienteButton.Name = "clienteButton";
            this.clienteButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.clienteButton.Size = new System.Drawing.Size(200, 23);
            this.clienteButton.TabIndex = 1;
            this.clienteButton.Text = "Cliente";
            this.clienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clienteButton.UseVisualStyleBackColor = true;
            this.clienteButton.Click += new System.EventHandler(this.clienteButton_Click);
            // 
            // bodegaButton
            // 
            this.bodegaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodegaButton.FlatAppearance.BorderSize = 0;
            this.bodegaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodegaButton.ForeColor = System.Drawing.Color.White;
            this.bodegaButton.Image = global::Login.Properties.Resources.bodegaNegro20x20;
            this.bodegaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bodegaButton.Location = new System.Drawing.Point(0, 0);
            this.bodegaButton.Name = "bodegaButton";
            this.bodegaButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bodegaButton.Size = new System.Drawing.Size(200, 23);
            this.bodegaButton.TabIndex = 0;
            this.bodegaButton.Text = "Bodega";
            this.bodegaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bodegaButton.UseVisualStyleBackColor = true;
            this.bodegaButton.Click += new System.EventHandler(this.bodegaButton_Click);
            // 
            // servicioButton
            // 
            this.servicioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicioButton.FlatAppearance.BorderSize = 0;
            this.servicioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicioButton.ForeColor = System.Drawing.Color.White;
            this.servicioButton.Image = global::Login.Properties.Resources.archivo2x20;
            this.servicioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.servicioButton.Location = new System.Drawing.Point(0, 100);
            this.servicioButton.Name = "servicioButton";
            this.servicioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.servicioButton.Size = new System.Drawing.Size(200, 29);
            this.servicioButton.TabIndex = 1;
            this.servicioButton.Text = "Archivo";
            this.servicioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicioButton.UseVisualStyleBackColor = true;
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Login.Properties.Resources.buho_orignal_sinDonfondo_letrasBlancas;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(191, 82);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // frmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 650);
            this.Controls.Add(this.pricipalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalMDI";
            this.Text = "frmPrincipalMDI";
            this.pricipalPanel.ResumeLayout(false);
            this.tituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).EndInit();
            this.menuVerticalPanel.ResumeLayout(false);
            this.movimientoPanel.ResumeLayout(false);
            this.archivoSubMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pricipalPanel;
        private System.Windows.Forms.Panel menuVerticalPanel;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.Panel tituloPanel;
        private System.Windows.Forms.Panel archivoSubMenuPanel;
        private System.Windows.Forms.Button servicioButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button bodegaButton;
        private System.Windows.Forms.Button cabioClaveButton;
        private System.Windows.Forms.Button cambioUsuarioButton;
        private System.Windows.Forms.Button usuarioButton;
        private System.Windows.Forms.Button tipoDocumentoButton;
        private System.Windows.Forms.Button proveedorButton;
        private System.Windows.Forms.Button productosButton;
        private System.Windows.Forms.Button clienteButton;
        private System.Windows.Forms.Panel movimientoPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button salidasButton;
        private System.Windows.Forms.Button traladosButton;
        private System.Windows.Forms.Button devolucionesButton;
        private System.Windows.Forms.Button comprasButton;
        private System.Windows.Forms.Button movimientoButton;
        private System.Windows.Forms.PictureBox slidePictureBox;
        private System.Windows.Forms.PictureBox minimizarPictureBox;
        private System.Windows.Forms.PictureBox restaurarPictureBox;
        private System.Windows.Forms.PictureBox maximizarPictureBox;
        private System.Windows.Forms.PictureBox cerrarPictureBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}