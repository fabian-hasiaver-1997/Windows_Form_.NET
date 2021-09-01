using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsuario;
namespace WinGestionComercial
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Es obligatorio informar el Nombre");
                return;
            }
            stUsuario stUS = new stUsuario();
            stUS.Nombre = txtNombre.Text;
            stUS.Apellido = txtApellido.Text;
            stUS.Edad = (int)nudEdad.Value;
            if (rbHombre.Checked)
                stUS.Sexo = Genero.Hombre;
            else
                stUS.Sexo = Genero.Mujer;
            if (txtComentario.Lines != null)
            {
                stUS.Comentarios = txtComentario.Lines;
            }
            if (ltsExperiencia.SelectedIndex != -1) 
            {
                stUS.Experiencia = ltsExperiencia.SelectedItem.ToString();
            }
            MostrarUsuario(stUS);
        }
        public void MostrarUsuario(stUsuario stUS) 
        {
            string strMsg = "";
            strMsg += stUS.Nombre + "\n";
            strMsg += stUS.Apellido + "\n";
            strMsg += stUS.Edad.ToString() +"\n";
            strMsg += stUS.Sexo.ToString () + "\n";
            foreach (string strComentarios in stUS.Comentarios) 
            {
                strMsg += stUS.Comentarios + "\n";
            }
            strMsg += stUS.Experiencia + "\n";
             MessageBox.Show(strMsg);
        }
    }
}
