using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGestionComercial
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 122);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 283);
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 122);
        }


    }
}
