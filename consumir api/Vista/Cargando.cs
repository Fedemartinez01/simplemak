using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm_Cargando : Form
    {
        #region Atributos

        public bool Cancel { get; set; } = true;
        frmPrincipal? FrmPrincipal;
        #endregion

        #region Constructor

        public frm_Cargando(int segundos)
        {
            InitializeComponent();
            DateTime horaEstimada = DateTime.Now.AddSeconds(segundos);
            this.labelCarga.Text = $"Hora estimada de finalizacion:\n{horaEstimada.ToString("HH:mm")}";
        }
        public frm_Cargando(int segundos, frmPrincipal form)
        {
            InitializeComponent();
            FrmPrincipal = form;
            DateTime horaEstimada = DateTime.Now.AddSeconds(segundos);
            this.labelCarga.Text = $"Hora estimada de finalizacion:\n{horaEstimada.ToString("HH:mm")}";
        }
        #endregion

        #region Metodos

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Cancel = false;

            if (FrmPrincipal is not null)
                FrmPrincipal.DesbloquearInputs();
        }
        private void DesbloquearInputs(object sender, FormClosedEventArgs e)
        {
            if(FrmPrincipal is not null)
                FrmPrincipal.DesbloquearInputs();
        }
        #endregion
    }
}
