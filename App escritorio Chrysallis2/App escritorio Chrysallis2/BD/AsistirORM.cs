using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_escritorio_Chrysallis2.BD
{
    public static class AsistirORM
    {


        public static List<assistir> SellectAsistentesByEvento(int idEvento, ref string mensaje)
        {
            List<assistir> asistencias = null;

            try
            {
                asistencias = (from a in ORM.bd.assistir where a.id_esdeveniment == idEvento select a).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }


            return asistencias;
        }



        public static List<Soci> SellectSociosAsistentesByEvento(int idEvento, ref string mensaje)
        {

            List<Soci> socios = null;

            
            try
            {
                socios = (from a in ORM.bd.assistir where a.id_esdeveniment == idEvento select a.Soci).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }


            return socios;


        }
        public static assistir SellectAsistentesBySocio(Soci socio, int idEvento, ref string mensaje)
        {
            assistir asistencia = null;

            try
            {
                asistencia = (from a in ORM.bd.assistir where a.Soci.id == socio.id && a.id_esdeveniment == idEvento select a).FirstOrDefault();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación"; 
            }

            return asistencia;
        }

    }
}
