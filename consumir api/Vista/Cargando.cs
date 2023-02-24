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
        public bool Cancel { get; set; } = true;
        public frm_Cargando(int segundos)
        {
            InitializeComponent();
            DateTime horaEstimada = DateTime.Now.AddSeconds(segundos);
            this.labelCarga.Text = $"Hora estimada de finalizacion:\n{horaEstimada.ToString("HH:mm")}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Cancel = false; ;
        }


    }
}
