namespace Login
{
    partial class frmCliente
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
            System.Windows.Forms.Label iDClienteLabel;
            System.Windows.Forms.Label iDTipoDocumentoLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombreComercialLabel;
            System.Windows.Forms.Label nombresContactoLabel;
            System.Windows.Forms.Label apellidosContactoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label aniversarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PrimeroTtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AnteriroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SiguienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UltimoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BuscarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDClienteTextBox = new System.Windows.Forms.TextBox();
            this.iDTipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSALl = new Login.DSAll.DSALl();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.nombreComercialTextBox = new System.Windows.Forms.TextBox();
            this.nombresContactoTextBox = new System.Windows.Forms.TextBox();
            this.apellidosContactoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefono1TextBox = new System.Windows.Forms.TextBox();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.aniversarioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoDocumentoTableAdapter = new Login.DSAll.DSALlTableAdapters.TipoDocumentoTableAdapter();
            iDClienteLabel = new System.Windows.Forms.Label();
            iDTipoDocumentoLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombreComercialLabel = new System.Windows.Forms.Label();
            nombresContactoLabel = new System.Windows.Forms.Label();
            apellidosContactoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            telefono2Label = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            aniversarioLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSALl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDClienteLabel
            // 
            iDClienteLabel.AutoSize = true;
            iDClienteLabel.Location = new System.Drawing.Point(16, 37);
            iDClienteLabel.Name = "iDClienteLabel";
            iDClienteLabel.Size = new System.Drawing.Size(53, 13);
            iDClienteLabel.TabIndex = 2;
            iDClienteLabel.Text = "IDCliente:";
            // 
            // iDTipoDocumentoLabel
            // 
            iDTipoDocumentoLabel.AutoSize = true;
            iDTipoDocumentoLabel.Location = new System.Drawing.Point(243, 40);
            iDTipoDocumentoLabel.Name = "iDTipoDocumentoLabel";
            iDTipoDocumentoLabel.Size = new System.Drawing.Size(100, 13);
            iDTipoDocumentoLabel.TabIndex = 4;
            iDTipoDocumentoLabel.Text = "IDTipo Documento:";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(566, 38);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 6;
            documentoLabel.Text = "Documento:";
            // 
            // nombreComercialLabel
            // 
            nombreComercialLabel.AutoSize = true;
            nombreComercialLabel.Location = new System.Drawing.Point(16, 65);
            nombreComercialLabel.Name = "nombreComercialLabel";
            nombreComercialLabel.Size = new System.Drawing.Size(96, 13);
            nombreComercialLabel.TabIndex = 8;
            nombreComercialLabel.Text = "Nombre Comercial:";
            // 
            // nombresContactoLabel
            // 
            nombresContactoLabel.AutoSize = true;
            nombresContactoLabel.Location = new System.Drawing.Point(243, 65);
            nombresContactoLabel.Name = "nombresContactoLabel";
            nombresContactoLabel.Size = new System.Drawing.Size(98, 13);
            nombresContactoLabel.TabIndex = 10;
            nombresContactoLabel.Text = "Nombres Contacto:";
            // 
            // apellidosContactoLabel
            // 
            apellidosContactoLabel.AutoSize = true;
            apellidosContactoLabel.Location = new System.Drawing.Point(566, 65);
            apellidosContactoLabel.Name = "apellidosContactoLabel";
            apellidosContactoLabel.Size = new System.Drawing.Size(98, 13);
            apellidosContactoLabel.TabIndex = 12;
            apellidosContactoLabel.Text = "Apellidos Contacto:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(16, 93);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Direccion:";
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(243, 90);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(58, 13);
            telefono1Label.TabIndex = 16;
            telefono1Label.Text = "Telefono1:";
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(573, 92);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(58, 13);
            telefono2Label.TabIndex = 18;
            telefono2Label.Text = "Telefono2:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(16, 121);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 20;
            correoLabel.Text = "Correo:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(12, 149);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 22;
            notasLabel.Text = "Notas:";
            // 
            // aniversarioLabel
            // 
            aniversarioLabel.AutoSize = true;
            aniversarioLabel.Location = new System.Drawing.Point(243, 115);
            aniversarioLabel.Name = "aniversarioLabel";
            aniversarioLabel.Size = new System.Drawing.Size(62, 13);
            aniversarioLabel.TabIndex = 24;
            aniversarioLabel.Text = "Aniversario:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrimeroTtoolStripButton,
            this.AnteriroToolStripButton,
            this.SiguienteToolStripButton,
            this.UltimoToolStripButton,
            this.toolStripSeparator1,
            this.ModificarToolStripButton,
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.GuardarToolStripButton,
            this.CancelarToolStripButton,
            this.BuscarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PrimeroTtoolStripButton
            // 
            this.PrimeroTtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrimeroTtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrimeroTtoolStripButton.Image")));
            this.PrimeroTtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrimeroTtoolStripButton.Name = "PrimeroTtoolStripButton";
            this.PrimeroTtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrimeroTtoolStripButton.Text = "toolStripButton1";
            this.PrimeroTtoolStripButton.Click += new System.EventHandler(this.PrimeroTtoolStripButton_Click);
            // 
            // AnteriroToolStripButton
            // 
            this.AnteriroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AnteriroToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AnteriroToolStripButton.Image")));
            this.AnteriroToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnteriroToolStripButton.Name = "AnteriroToolStripButton";
            this.AnteriroToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AnteriroToolStripButton.Text = "toolStripButton2";
            this.AnteriroToolStripButton.Click += new System.EventHandler(this.AnteriroToolStripButton_Click);
            // 
            // SiguienteToolStripButton
            // 
            this.SiguienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SiguienteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SiguienteToolStripButton.Image")));
            this.SiguienteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SiguienteToolStripButton.Name = "SiguienteToolStripButton";
            this.SiguienteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SiguienteToolStripButton.Text = "toolStripButton3";
            this.SiguienteToolStripButton.Click += new System.EventHandler(this.SiguienteToolStripButton_Click);
            // 
            // UltimoToolStripButton
            // 
            this.UltimoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UltimoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UltimoToolStripButton.Image")));
            this.UltimoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UltimoToolStripButton.Name = "UltimoToolStripButton";
            this.UltimoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UltimoToolStripButton.Text = "toolStripButton4";
            this.UltimoToolStripButton.Click += new System.EventHandler(this.UltimoToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ModificarToolStripButton
            // 
            this.ModificarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModificarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ModificarToolStripButton.Image")));
            this.ModificarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarToolStripButton.Name = "ModificarToolStripButton";
            this.ModificarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ModificarToolStripButton.Text = "toolStripButton5";
            this.ModificarToolStripButton.Click += new System.EventHandler(this.ModificarToolStripButton_Click);
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NuevoToolStripButton.Text = "toolStripButton6";
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BorrarToolStripButton.Text = "toolStripButton7";
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripButton.Image")));
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.GuardarToolStripButton.Text = "toolStripButton8";
            this.GuardarToolStripButton.Click += new System.EventHandler(this.GuardarToolStripButton_Click);
            // 
            // CancelarToolStripButton
            // 
            this.CancelarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarToolStripButton.Image")));
            this.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarToolStripButton.Name = "CancelarToolStripButton";
            this.CancelarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CancelarToolStripButton.Text = "toolStripButton9";
            this.CancelarToolStripButton.Click += new System.EventHandler(this.CancelarToolStripButton_Click);
            // 
            // BuscarToolStripButton
            // 
            this.BuscarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarToolStripButton.Image")));
            this.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarToolStripButton.Name = "BuscarToolStripButton";
            this.BuscarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BuscarToolStripButton.Text = "toolStripButton10";
            this.BuscarToolStripButton.Click += new System.EventHandler(this.BuscarToolStripButton_Click);
            // 
            // iDClienteTextBox
            // 
            this.iDClienteTextBox.Location = new System.Drawing.Point(118, 37);
            this.iDClienteTextBox.Name = "iDClienteTextBox";
            this.iDClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDClienteTextBox.TabIndex = 3;
            // 
            // iDTipoDocumentoComboBox
            // 
            this.iDTipoDocumentoComboBox.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoComboBox.DisplayMember = "Descripcion";
            this.iDTipoDocumentoComboBox.FormattingEnabled = true;
            this.iDTipoDocumentoComboBox.Location = new System.Drawing.Point(361, 30);
            this.iDTipoDocumentoComboBox.Name = "iDTipoDocumentoComboBox";
            this.iDTipoDocumentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDTipoDocumentoComboBox.TabIndex = 5;
            this.iDTipoDocumentoComboBox.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSALl;
            // 
            // dSALl
            // 
            this.dSALl.DataSetName = "DSALl";
            this.dSALl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(670, 32);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 7;
            // 
            // nombreComercialTextBox
            // 
            this.nombreComercialTextBox.Location = new System.Drawing.Point(118, 63);
            this.nombreComercialTextBox.Name = "nombreComercialTextBox";
            this.nombreComercialTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreComercialTextBox.TabIndex = 9;
            // 
            // nombresContactoTextBox
            // 
            this.nombresContactoTextBox.Location = new System.Drawing.Point(361, 58);
            this.nombresContactoTextBox.Name = "nombresContactoTextBox";
            this.nombresContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresContactoTextBox.TabIndex = 11;
            // 
            // apellidosContactoTextBox
            // 
            this.apellidosContactoTextBox.Location = new System.Drawing.Point(670, 58);
            this.apellidosContactoTextBox.Name = "apellidosContactoTextBox";
            this.apellidosContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosContactoTextBox.TabIndex = 13;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(118, 89);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // telefono1TextBox
            // 
            this.telefono1TextBox.Location = new System.Drawing.Point(361, 85);
            this.telefono1TextBox.Name = "telefono1TextBox";
            this.telefono1TextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono1TextBox.TabIndex = 17;
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.Location = new System.Drawing.Point(670, 84);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono2TextBox.TabIndex = 19;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(118, 115);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoTextBox.TabIndex = 21;
            // 
            // notasTextBox
            // 
            this.notasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notasTextBox.Location = new System.Drawing.Point(118, 141);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(652, 56);
            this.notasTextBox.TabIndex = 23;
            // 
            // aniversarioDateTimePicker
            // 
            this.aniversarioDateTimePicker.Location = new System.Drawing.Point(361, 112);
            this.aniversarioDateTimePicker.Name = "aniversarioDateTimePicker";
            this.aniversarioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.aniversarioDateTimePicker.TabIndex = 25;
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(0, 221);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(829, 231);
            this.clientesDataGridView.TabIndex = 26;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(aniversarioLabel);
            this.Controls.Add(this.aniversarioDateTimePicker);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(this.telefono2TextBox);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(this.telefono1TextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidosContactoLabel);
            this.Controls.Add(this.apellidosContactoTextBox);
            this.Controls.Add(nombresContactoLabel);
            this.Controls.Add(this.nombresContactoTextBox);
            this.Controls.Add(nombreComercialLabel);
            this.Controls.Add(this.nombreComercialTextBox);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(iDTipoDocumentoLabel);
            this.Controls.Add(this.iDTipoDocumentoComboBox);
            this.Controls.Add(iDClienteLabel);
            this.Controls.Add(this.iDClienteTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSALl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PrimeroTtoolStripButton;
        private System.Windows.Forms.ToolStripButton AnteriroToolStripButton;
        private System.Windows.Forms.ToolStripButton SiguienteToolStripButton;
        private System.Windows.Forms.ToolStripButton UltimoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ModificarToolStripButton;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
        private System.Windows.Forms.ToolStripButton CancelarToolStripButton;
        private System.Windows.Forms.ToolStripButton BuscarToolStripButton;
        private System.Windows.Forms.TextBox iDClienteTextBox;
        private System.Windows.Forms.ComboBox iDTipoDocumentoComboBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombreComercialTextBox;
        private System.Windows.Forms.TextBox nombresContactoTextBox;
        private System.Windows.Forms.TextBox apellidosContactoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefono1TextBox;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.DateTimePicker aniversarioDateTimePicker;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private DSAll.DSALl dSALl;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAll.DSALlTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
    }
}