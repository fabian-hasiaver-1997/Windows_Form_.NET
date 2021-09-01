using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace LibGestionComercialBD
{
    public class Conexion
    {
        public static OleDbConnection ObtenerConexion() 
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Users\\ale\\Documents\\Visual Studio 2012\\Projects\\FrmInicio\\GestionComercial.accdb'");
            try
            {
                con.Open();
                return con;
            }

            catch (Exception ex) 
            {
                return null;
            }
        }
    }
}
