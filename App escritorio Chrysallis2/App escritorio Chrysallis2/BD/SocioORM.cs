using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_escritorio_Chrysallis2.BD
{
    public static class SocioORM
    {
        public static List<Soci> SellectAllSocios(ref string mensaje)
        {
            
            List<Soci> socis = null;
            try
            {
                socis = (from s in ORM.bd.Soci orderby s.nom select s).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return socis;
        }
        public static List<Soci> SellectSociosByNom(String texto, ref string mensaje)
        {
            List<Soci> socis = null;

            try
            {
                socis = (from s in ORM.bd.Soci where s.nom.Contains(texto) orderby s.nom select s).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return socis;
        }
        public static List<Soci> SellectSociosByApellido(String texto, ref string mensaje)
        {
            List<Soci> socis = null;

            try
            {
                socis = (from s in ORM.bd.Soci where s.cognoms.Contains(texto) orderby s.cognoms select s).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return socis;
        }
        public static List<Soci> SellectSociosByTelefono(String texto, ref string mensaje)
        {
            List<Soci> socis = null;

            try
            {
                socis = (from s in ORM.bd.Soci where s.telefon.Contains(texto) orderby s.telefon select s).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return socis;
        }
        public static String InsertSoci(String telefono, String mail, String nom, String cognoms, String contrasenya, Boolean actiu, Boolean admin)
        {

            String mensaje = "";
            Soci soci = new Soci();

            soci.telefon = telefono;
            soci.mail = mail;
            soci.nom = nom;
            soci.cognoms = cognoms;
            soci.contrasenya = contrasenya;
            soci.actiu = actiu;
            soci.administrador = admin;

            ORM.bd.Soci.Add(soci);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        public static String UpdateSoci(Soci soci, String nombre, String telefono, String mail, String nom, String cognoms, Boolean actiu, Boolean admin)
        {

            String mensaje = "";
            soci.nom = nombre;
            soci.telefon = telefono;
            soci.mail = mail;
            soci.cognoms = cognoms;
            soci.actiu = actiu;
            soci.administrador = admin;

            mensaje = ORM.SaveChanges();

            return mensaje;

        }

        public static String DeleteSoci(Soci soci)
        {
            String mensaje = "";
            
            ORM.bd.Soci.Remove(soci);

            mensaje = ORM.SaveChanges();

            return mensaje;

        }
    }
}
