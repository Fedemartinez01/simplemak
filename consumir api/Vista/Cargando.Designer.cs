namespace Vista
{
    partial class frm_Cargando
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cargando
            // 
            this.lbl_Cargando.AutoSize = true;
            this.lbl_Cargando.Location = new System.Drawing.Point(105, 37);
            this.lbl_Cargando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cargando.Name = "lbl_Cargando";
            this.lbl_Cargando.Size = new System.Drawing.Size(107, 18);
            this.lbl_Cargando.TabIndex = 0;
            this.lbl_Cargando.Text = "CARGANDO...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelCarga
            // 
            this.labelCarga.AutoSize = true;
            this.labelCarga.Location = new System.Drawing.Point(12, 76);
            this.labelCarga.Name = "labelCarga";
            this.labelCarga.Size = new System.Drawing.Size(0, 18);
            this.labelCarga.TabIndex = 2;
            // 
            // frm_Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 141);
            this.ControlBox = false;
            this.Controls.Add(this.labelCarga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Cargando);
            this.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Cargando";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGANDO EN COLPPY...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Cargando;
        private PictureBox pictureBox1;
        private Label labelCarga;
    }
}