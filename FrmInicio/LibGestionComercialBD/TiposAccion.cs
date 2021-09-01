using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace LibGestionComercialBD
{
    public class TiposAccion : IDisposable
    {
        private OleDbConnection con;
        public TiposAccion() 
        {
            con = Conexion.ObtenerConexion();
        }
        public void Dispose() 
        {
            if (con.State != ConnectionState.Closed) 
            {
                con.Close();
            }
        }
        public ArrayList GetTiposAccion() 
        {
            OleDbCommand com = new OleDbCommand("select * from tiposaccion", con);
            ArrayList arr = new ArrayList();
            try
            {
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    arr.Add(new ItemTiposAccion(int.Parse(dr.GetValue(0).ToString()), dr.GetString(1)));

                }
                dr.Close();
                return arr;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
 
    }
}
