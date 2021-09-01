using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGestionComercialBD;
using System.Data.OleDb;

namespace WinGestionComercial
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.Text = "Gestión Comercial - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void mostrarAcercaDe() 
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            mostrarAcercaDe();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frn = new FrmUsuario();
            frn.ShowDialog();
            frn.Dispose();
        }

        private FrmGoogle frmG;

        private void lnkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmG == null)
            {
                frmG = new FrmGoogle();
                frmG.Show();
            }
            else 
            {
                if (frmG.IsDisposed)
                {
                    frmG = new FrmGoogle();
                    frmG.Show();
                }
                else 
                {
                    frmG.Activate();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mostrarCalendarioToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.mcHoy.Visible = this.mostrarCalendarioToolStripMenuItem.Checked;
        }

        private void usuarioDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frn = new FrmUsuario();
            frn.ShowDialog();
            frn.Dispose();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarAcercaDe();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmSalida frm = new FrmSalida();
            DialogResult respuesta = frm.ShowDialog();
            if(respuesta == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private FrmClientes frmCli;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmCli == null)
            {
                frmCli = new FrmClientes();
                frmCli.Show();
            }
            else 
            {
                if (frmCli.IsDisposed)
                {
                    frmCli = new FrmClientes();
                    frmCli.Show();
                }
                else 
                {
                    frmCli.Activate();
                }
            }
        }

        private void probarLaConexiónALaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection con = Conexion.ObtenerConexion();
            if (con != null)
            {
                MessageBox.Show("Conexión Correcta");
                con.Close();
            }
            else 
            {
                MessageBox.Show("Ha fallado la Conexión");
            }
        }

        private FrmTiposAccion FrmTa;
        private void tiposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmTa == null)
            {
                FrmTa = new FrmTiposAccion();
                FrmTa.Show();
            }
            else 
            {
                if (FrmTa.IsDisposed)
                {
                    FrmTa = new FrmTiposAccion();
                    FrmTa.Show();
                }
                else 
                {
                    FrmTa.Activate();
                }
            }
        }
    }
}
