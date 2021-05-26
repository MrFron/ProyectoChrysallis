using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_escritorio_Chrysallis2.BD
{
    public static class ComunidadesORM
    {

        public static List<comunitats> SellectAllComunitats(ref string mensaje)
        {
            List<comunitats> comunitats = null;
            try
            {
                comunitats = (from c in ORM.bd.comunitats orderby c.nom select c).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "Error en la conexión con la base de datos. Se cerrará la aplicación.";
            }
                

            return comunitats;
        }

        
            
    }
}
