namespace Vista
{
    partial class frmPrincipal
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
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarClientes = new System.Windows.Forms.Button();
            this.cmbVistaListado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.btnCargarProveedores = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listadoProveedores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoClientes
            // 
            this.listadoClientes.AllowUserToAddRows = false;
            this.listadoClientes.AllowUserToDeleteRows = false;
            this.listadoClientes.AllowUserToResizeColumns = false;
            this.listadoClientes.AllowUserToResizeRows = false;
            this.listadoClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listadoClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.listadoClientes.BackgroundColor = System.Drawing.Color.White;
            this.listadoClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idEmpresa,
            this.nombreFantasia,
            this.razonSocial,
            this.cuit,
            this.dni,
            this.direccion,
            this.ciudad,
            this.codigoPostal,
            this.provincia,
            this.pais,
            this.telefono,
            this.email,
            this.activo,
            this.fechaAlta});
            this.listadoClientes.Location = new System.Drawing.Point(16, 58);
            this.listadoClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listadoClientes.MultiSelect = false;
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.ReadOnly = true;
            this.listadoClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listadoClientes.RowTemplate.Height = 25;
            this.listadoClientes.Size = new System.Drawing.Size(1279, 454);
            this.listadoClientes.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 51;
            // 
            // idEmpresa
            // 
            this.idEmpresa.HeaderText = "IDEmpresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.ReadOnly = true;
            this.idEmpresa.Width = 114;
            // 
            // nombreFantasia
            // 
            this.nombreFantasia.HeaderText = "NombreFantasia";
            this.nombreFantasia.Name = "nombreFantasia";
            this.nombreFantasia.ReadOnly = true;
            this.nombreFantasia.Width = 159;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "RazonSocial";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 132;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Width = 69;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 60;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 114;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            this.ciudad.Width = 87;
            // 
            // codigoPostal
            // 
            this.codigoPostal.HeaderText = "CodigoPostal";
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.ReadOnly = true;
            this.codigoPostal.Width = 141;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 114;
            // 
            // pais
            // 
            this.pais.HeaderText = "Pais";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            this.pais.Width = 69;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 105;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 78;
            // 
            // activo
            // 
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 87;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "FechaAlta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            this.fechaAlta.Width = 114;
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.BackColor = System.Drawing.Color.White;
            this.btnCargarClientes.Location = new System.Drawing.Point(16, 521);
            this.btnCargarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(182, 58);
            this.btnCargarClientes.TabIndex = 7;
            this.btnCargarClientes.Text = "CARGAR CLIENTES";
            this.btnCargarClientes.UseVisualStyleBackColor = false;
            this.btnCargarClientes.Click += new System.EventHandler(this.btnCargarClientes_Click);
            // 
            // cmbVistaListado
            // 
            this.cmbVistaListado.BackColor = System.Drawing.Color.White;
            this.cmbVistaListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVistaListado.FormattingEnabled = true;
            this.cmbVistaListado.Items.AddRange(new object[] {
            "Clientes",
            "Proveedores",
            "Productos"});
            this.cmbVistaListado.Location = new System.Drawing.Point(66, 14);
            this.cmbVistaListado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVistaListado.Name = "cmbVistaListado";
            this.cmbVistaListado.Size = new System.Drawing.Size(155, 26);
            this.cmbVistaListado.TabIndex = 8;
            this.cmbVistaListado.SelectedIndexChanged += new System.EventHandler(this.CambioListado);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ver";
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.BackColor = System.Drawing.Color.White;
            this.btnCargarProductos.Location = new System.Drawing.Point(288, 521);
            this.btnCargarProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(182, 58);
            this.btnCargarProductos.TabIndex = 10;
            this.btnCargarProductos.Text = "CARGAR PRODUCTOS";
            this.btnCargarProductos.UseVisualStyleBackColor = false;
            // 
            // btnCargarProveedores
            // 
            this.btnCargarProveedores.BackColor = System.Drawing.Color.White;
            this.btnCargarProveedores.Location = new System.Drawing.Point(559, 521);
            this.btnCargarProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarProveedores.Name = "btnCargarProveedores";
            this.btnCargarProveedores.Size = new System.Drawing.Size(182, 58);
            this.btnCargarProveedores.TabIndex = 11;
            this.btnCargarProveedores.Text = "CARGAR PROVEEDORES";
            this.btnCargarProveedores.UseVisualStyleBackColor = false;
            this.btnCargarProveedores.Click += new System.EventHandler(this.btnCargarProveedores_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "RazonSocial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 132;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "NombreFantasia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 159;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 114;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 87;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "CodigoPostal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 141;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 114;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IDEmpresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 114;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 69;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CUIT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Email";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 78;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 87;
            // 
            // listadoProveedores
            // 
            this.listadoProveedores.AllowUserToAddRows = false;
            this.listadoProveedores.AllowUserToDeleteRows = false;
            this.listadoProveedores.AllowUserToResizeColumns = false;
            this.listadoProveedores.AllowUserToResizeRows = false;
            this.listadoProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listadoProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.listadoProveedores.BackgroundColor = System.Drawing.Color.White;
            this.listadoProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.listadoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn26,
            this.condicionIVA});
            this.listadoProveedores.Location = new System.Drawing.Point(16, 59);
            this.listadoProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listadoProveedores.MultiSelect = false;
            this.listadoProveedores.Name = "listadoProveedores";
            this.listadoProveedores.ReadOnly = true;
            this.listadoProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listadoProveedores.RowTemplate.Height = 25;
            this.listadoProveedores.Size = new System.Drawing.Size(1279, 454);
            this.listadoProveedores.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "NombreFantasia";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 159;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "RazonSocial";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 132;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 114;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 87;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "CodigoPostal";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 141;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 114;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 69;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "CUIT";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 51;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 87;
            // 
            // condicionIVA
            // 
            this.condicionIVA.HeaderText = "Condicion IVA";
            this.condicionIVA.Name = "condicionIVA";
            this.condicionIVA.ReadOnly = true;
            this.condicionIVA.Width = 137;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1311, 582);
            this.Controls.Add(this.listadoProveedores);
            this.Controls.Add(this.btnCargarProveedores);
            this.Controls.Add(this.btnCargarProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVistaListado);
            this.Controls.Add(this.btnCargarClientes);
            this.Controls.Add(this.listadoClientes);
            this.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMPLEMAK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TextChanged += new System.EventHandler(this.CambioListado);
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView listadoClientes;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn idEmpresa;
        private DataGridViewTextBoxColumn nombreFantasia;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn ciudad;
        private DataGridViewTextBoxColumn codigoPostal;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn pais;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewTextBoxColumn fechaAlta;
        private Button btnCargarClientes;
        private ComboBox cmbVistaListado;
        private Label label1;
        private Button btnCargarProductos;
        private Button btnCargarProveedores;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridView listadoProveedores;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn condicionIVA;
    }
}