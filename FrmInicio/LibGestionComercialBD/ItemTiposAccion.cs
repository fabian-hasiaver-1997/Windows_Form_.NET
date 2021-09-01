using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGestionComercialBD
{
    public class ItemTiposAccion
    {
        private int mIdTipoAccion;
        private string mDescripcion;
        public ItemTiposAccion(int pIdTipoAccion, string pDescripcion)
        {
            mIdTipoAccion = pIdTipoAccion;
            mDescripcion = pDescripcion;
        }

        public int IdTipoAccion
        {
            get
               {
                   return mIdTipoAccion;
               }
        }
        public string Descripcion 
        {
            get 
            {
                return mDescripcion;
            }
        }
        public override string ToString()
        {
            return mDescripcion;
        }
    }
}
