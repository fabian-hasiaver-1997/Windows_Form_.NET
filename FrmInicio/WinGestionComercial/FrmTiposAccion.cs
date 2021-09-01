using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibGestionComercialBD;
using System.Collections;

namespace WinGestionComercial
{
    public partial class FrmTiposAccion : WinGestionComercial.FrmBase
    {
        public FrmTiposAccion()
        {
            InitializeComponent();
        }

        private void FrmTiposAccion_Load(object sender, EventArgs e)
        {
            TiposAccion ta = new TiposAccion();
            ArrayList arr = ta.GetTiposAccion();
            ta.Dispose();
            foreach (ItemTiposAccion ita in arr) 
            {
                lstTiposAccion.Items.Add(ita);
            }
        }
    }
}
