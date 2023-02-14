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
            this.btnCargarClientes = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargarTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.txt_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCargarClientes.BackColor = System.Drawing.Color.White;
            this.btnCargarClientes.Location = new System.Drawing.Point(31, 237);
            this.btnCargarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(196, 66);
            this.btnCargarClientes.TabIndex = 7;
            this.btnCargarClientes.Text = "CARGAR CLIENTES";
            this.btnCargarClientes.UseVisualStyleBackColor = false;
            this.btnCargarClientes.Click += new System.EventHandler(this.btnCargarClientes_Click);
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCargarProductos.BackColor = System.Drawing.Color.White;
            this.btnCargarProductos.Location = new System.Drawing.Point(31, 346);
            this.btnCargarProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(196, 64);
            this.btnCargarProductos.TabIndex = 10;
            this.btnCargarProductos.Text = "CARGAR PRODUCTOS";
            this.btnCargarProductos.UseVisualStyleBackColor = false;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click_1);
            // 
            // btnCargarProveedores
            // 
            this.btnCargarProveedores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCargarProveedores.BackColor = System.Drawing.Color.White;
            this.btnCargarProveedores.Location = new System.Drawing.Point(301, 237);
            this.btnCargarProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarProveedores.Name = "btnCargarProveedores";
            this.btnCargarProveedores.Size = new System.Drawing.Size(196, 64);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(104, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 39);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargarTodos
            // 
            this.btnCargarTodos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCargarTodos.BackColor = System.Drawing.Color.White;
            this.btnCargarTodos.Location = new System.Drawing.Point(301, 346);
            this.btnCargarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarTodos.Name = "btnCargarTodos";
            this.btnCargarTodos.Size = new System.Drawing.Size(196, 64);
            this.btnCargarTodos.TabIndex = 14;
            this.btnCargarTodos.Text = "CARGAR TODOS";
            this.btnCargarTodos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "DESDE";
            // 
            // txt_FechaFin
            // 
            this.txt_FechaFin.Location = new System.Drawing.Point(101, 157);
            this.txt_FechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FechaFin.Name = "txt_FechaFin";
            this.txt_FechaFin.Size = new System.Drawing.Size(373, 25);
            this.txt_FechaFin.TabIndex = 16;
            // 
            // txt_FechaInicio
            // 
            this.txt_FechaInicio.Location = new System.Drawing.Point(104, 113);
            this.txt_FechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FechaInicio.Name = "txt_FechaInicio";
            this.txt_FechaInicio.Size = new System.Drawing.Size(370, 25);
            this.txt_FechaInicio.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "SISTEMA DE CARGA A COLPPY";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Vista.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(525, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_FechaFin);
            this.Controls.Add(this.txt_FechaInicio);
            this.Controls.Add(this.btnCargarTodos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCargarProveedores);
            this.Controls.Add(this.btnCargarProductos);
            this.Controls.Add(this.btnCargarClientes);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMPLEMAK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCargarClientes;
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
        private PictureBox pictureBox1;
        private Button btnCargarTodos;
        private Label label2;
        private Label label3;
        private DateTimePicker txt_FechaFin;
        private DateTimePicker txt_FechaInicio;
        private Label label1;
    }
}