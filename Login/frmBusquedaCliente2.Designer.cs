namespace Login
{
    partial class frmBusquedaCliente2
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
            this.empieceRataGridView = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new Login.DS.DSAplicacionComercial();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniversarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Login.DS.DSAplicacionComercialTableAdapters.ClienteTableAdapter();
            this.tipoDocumentoTableAdapter = new Login.DS.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter();
            this.busquedaCliente2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreComercialToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreComercialToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombresContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.busquedaCliente2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eleccionGroupBox = new System.Windows.Forms.GroupBox();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.termineRadioButton = new System.Windows.Forms.RadioButton();
            this.empieceRadioButton = new System.Windows.Forms.RadioButton();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empieceRataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.busquedaCliente2ToolStrip.SuspendLayout();
            this.eleccionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // empieceRataGridView
            // 
            this.empieceRataGridView.AllowUserToAddRows = false;
            this.empieceRataGridView.AllowUserToDeleteRows = false;
            this.empieceRataGridView.AllowUserToOrderColumns = true;
            this.empieceRataGridView.AutoGenerateColumns = false;
            this.empieceRataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empieceRataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDTipoDocumentoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombreComercialDataGridViewTextBoxColumn,
            this.nombresContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.aniversarioDataGridViewTextBoxColumn});
            this.empieceRataGridView.DataSource = this.clienteBindingSource;
            this.empieceRataGridView.Location = new System.Drawing.Point(2, 204);
            this.empieceRataGridView.Name = "empieceRataGridView";
            this.empieceRataGridView.ReadOnly = true;
            this.empieceRataGridView.Size = new System.Drawing.Size(798, 248);
            this.empieceRataGridView.TabIndex = 0;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Name = "iDTipoDocumentoDataGridViewTextBoxColumn";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreComercialDataGridViewTextBoxColumn
            // 
            this.nombreComercialDataGridViewTextBoxColumn.DataPropertyName = "NombreComercial";
            this.nombreComercialDataGridViewTextBoxColumn.HeaderText = "NombreComercial";
            this.nombreComercialDataGridViewTextBoxColumn.Name = "nombreComercialDataGridViewTextBoxColumn";
            this.nombreComercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresContactoDataGridViewTextBoxColumn
            // 
            this.nombresContactoDataGridViewTextBoxColumn.DataPropertyName = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.HeaderText = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.Name = "nombresContactoDataGridViewTextBoxColumn";
            this.nombresContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosContactoDataGridViewTextBoxColumn
            // 
            this.apellidosContactoDataGridViewTextBoxColumn.DataPropertyName = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.HeaderText = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.Name = "apellidosContactoDataGridViewTextBoxColumn";
            this.apellidosContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniversarioDataGridViewTextBoxColumn
            // 
            this.aniversarioDataGridViewTextBoxColumn.DataPropertyName = "Aniversario";
            this.aniversarioDataGridViewTextBoxColumn.HeaderText = "Aniversario";
            this.aniversarioDataGridViewTextBoxColumn.Name = "aniversarioDataGridViewTextBoxColumn";
            this.aniversarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // busquedaCliente2ToolStrip
            // 
            this.busquedaCliente2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreComercialToolStripLabel,
            this.nombreComercialToolStripTextBox,
            this.nombresContactoToolStripLabel,
            this.nombresContactoToolStripTextBox,
            this.apellidosContactoToolStripLabel,
            this.apellidosContactoToolStripTextBox,
            this.busquedaCliente2ToolStripButton});
            this.busquedaCliente2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.busquedaCliente2ToolStrip.Name = "busquedaCliente2ToolStrip";
            this.busquedaCliente2ToolStrip.Size = new System.Drawing.Size(820, 25);
            this.busquedaCliente2ToolStrip.TabIndex = 1;
            this.busquedaCliente2ToolStrip.Text = "busquedaCliente2ToolStrip";
            // 
            // nombreComercialToolStripLabel
            // 
            this.nombreComercialToolStripLabel.Name = "nombreComercialToolStripLabel";
            this.nombreComercialToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.nombreComercialToolStripLabel.Text = "NombreComercial:";
            // 
            // nombreComercialToolStripTextBox
            // 
            this.nombreComercialToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreComercialToolStripTextBox.Name = "nombreComercialToolStripTextBox";
            this.nombreComercialToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nombresContactoToolStripLabel
            // 
            this.nombresContactoToolStripLabel.Name = "nombresContactoToolStripLabel";
            this.nombresContactoToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.nombresContactoToolStripLabel.Text = "NombresContacto:";
            // 
            // nombresContactoToolStripTextBox
            // 
            this.nombresContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombresContactoToolStripTextBox.Name = "nombresContactoToolStripTextBox";
            this.nombresContactoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // apellidosContactoToolStripLabel
            // 
            this.apellidosContactoToolStripLabel.Name = "apellidosContactoToolStripLabel";
            this.apellidosContactoToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.apellidosContactoToolStripLabel.Text = "ApellidosContacto:";
            // 
            // apellidosContactoToolStripTextBox
            // 
            this.apellidosContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apellidosContactoToolStripTextBox.Name = "apellidosContactoToolStripTextBox";
            this.apellidosContactoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // busquedaCliente2ToolStripButton
            // 
            this.busquedaCliente2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busquedaCliente2ToolStripButton.Image = global::Login.Properties.Resources.search1_32x32;
            this.busquedaCliente2ToolStripButton.Name = "busquedaCliente2ToolStripButton";
            this.busquedaCliente2ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.busquedaCliente2ToolStripButton.Text = "BusquedaCliente2";
            this.busquedaCliente2ToolStripButton.Click += new System.EventHandler(this.busquedaCliente2ToolStripButton_Click);
            // 
            // eleccionGroupBox
            // 
            this.eleccionGroupBox.Controls.Add(this.reiniciarButton);
            this.eleccionGroupBox.Controls.Add(this.termineRadioButton);
            this.eleccionGroupBox.Controls.Add(this.empieceRadioButton);
            this.eleccionGroupBox.Controls.Add(this.contengaRadioButton);
            this.eleccionGroupBox.Location = new System.Drawing.Point(29, 68);
            this.eleccionGroupBox.Name = "eleccionGroupBox";
            this.eleccionGroupBox.Size = new System.Drawing.Size(383, 47);
            this.eleccionGroupBox.TabIndex = 2;
            this.eleccionGroupBox.TabStop = false;
            this.eleccionGroupBox.Text = "Caracter De Busqueda";
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.FlatAppearance.BorderSize = 0;
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciarButton.Image = global::Login.Properties.Resources.refresch1_32x32;
            this.reiniciarButton.Location = new System.Drawing.Point(302, 11);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(75, 30);
            this.reiniciarButton.TabIndex = 3;
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // termineRadioButton
            // 
            this.termineRadioButton.AutoSize = true;
            this.termineRadioButton.Location = new System.Drawing.Point(202, 19);
            this.termineRadioButton.Name = "termineRadioButton";
            this.termineRadioButton.Size = new System.Drawing.Size(63, 17);
            this.termineRadioButton.TabIndex = 2;
            this.termineRadioButton.TabStop = true;
            this.termineRadioButton.Text = "Termine";
            this.termineRadioButton.UseVisualStyleBackColor = true;
            // 
            // empieceRadioButton
            // 
            this.empieceRadioButton.AutoSize = true;
            this.empieceRadioButton.Location = new System.Drawing.Point(110, 19);
            this.empieceRadioButton.Name = "empieceRadioButton";
            this.empieceRadioButton.Size = new System.Drawing.Size(66, 17);
            this.empieceRadioButton.TabIndex = 1;
            this.empieceRadioButton.TabStop = true;
            this.empieceRadioButton.Text = "Empiece";
            this.empieceRadioButton.UseVisualStyleBackColor = true;
            // 
            // contengaRadioButton
            // 
            this.contengaRadioButton.AutoSize = true;
            this.contengaRadioButton.Location = new System.Drawing.Point(6, 19);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptarButton.FlatAppearance.BorderSize = 0;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Image = global::Login.Properties.Resources.aceptarinicio_32x321;
            this.aceptarButton.Location = new System.Drawing.Point(484, 70);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 42);
            this.aceptarButton.TabIndex = 3;
            this.aceptarButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Image = global::Login.Properties.Resources._32x32cerrar1;
            this.cancelarButton.Location = new System.Drawing.Point(622, 68);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 47);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaCliente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 472);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.eleccionGroupBox);
            this.Controls.Add(this.busquedaCliente2ToolStrip);
            this.Controls.Add(this.empieceRataGridView);
            this.Name = "frmBusquedaCliente2";
            this.Text = "frmBusquedaCliente2";
            this.Load += new System.EventHandler(this.frmBusquedaCliente2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empieceRataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.busquedaCliente2ToolStrip.ResumeLayout(false);
            this.busquedaCliente2ToolStrip.PerformLayout();
            this.eleccionGroupBox.ResumeLayout(false);
            this.eleccionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView empieceRataGridView;
        private DS.DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DS.DSAplicacionComercialTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DS.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniversarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip busquedaCliente2ToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreComercialToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreComercialToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombresContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton busquedaCliente2ToolStripButton;
        private System.Windows.Forms.GroupBox eleccionGroupBox;
        private System.Windows.Forms.RadioButton termineRadioButton;
        private System.Windows.Forms.RadioButton empieceRadioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}