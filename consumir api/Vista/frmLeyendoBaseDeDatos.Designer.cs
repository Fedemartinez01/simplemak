namespace Vista
{
    partial class frmLeyendoBaseDeDatos
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
            this.lbl_Cargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Cargando
            // 
            this.lbl_Cargando.AutoSize = true;
            this.lbl_Cargando.Location = new System.Drawing.Point(156, 57);
            this.lbl_Cargando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cargando.Name = "lbl_Cargando";
            this.lbl_Cargando.Size = new System.Drawing.Size(107, 18);
            this.lbl_Cargando.TabIndex = 1;
            this.lbl_Cargando.Text = "CARGANDO...";
            // 
            // frmLeyendoBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 135);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Cargando);
            this.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeyendoBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectura de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Cargando;
    }
}