using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_escritorio_Chrysallis2.BD
{
    public static class EventoORM
    {
        public static List<esdeveniments> SellectAllEsdeveniments(ref String mensaje)
        {
            List<esdeveniments> esdeveniments = null;

            try
            {
                esdeveniments = (from e in ORM.bd.esdeveniments orderby e.data select e).ToList();
            }
            catch (EntityException ex)
            {

                mensaje =  "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return esdeveniments;
        }

        public static List<esdeveniments> SellectEventosByNom(int comunidad, String texto, ref String mensaje)
        {
            List<esdeveniments> eventos = null;

            try
            {
                eventos = (from e in ORM.bd.esdeveniments where e.nom.Contains(texto) && e.id_comunitat == comunidad orderby e.nom select e).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return eventos;
        }
        public static List<esdeveniments> SellectEventosByUbicacion(String texto)
        {
            List<esdeveniments> eventos = (from e in ORM.bd.esdeveniments where e.ubicació.Contains(texto) orderby e.ubicació select e).ToList();

            return eventos;
        }
        public static List<esdeveniments> SellectEventosByFecha(String texto)
        {
            
            List<esdeveniments> eventos = (from e in ORM.bd.esdeveniments where e.data.Equals(texto) orderby e.data select e).ToList();

            return eventos;
        }
        public static List<esdeveniments> SellectEventosByHora(String texto)
        {
            List<esdeveniments> eventos = (from e in ORM.bd.esdeveniments where e.hora.Equals(texto) orderby e.hora select e).ToList();

            return eventos;
        }
        public static List<esdeveniments> SellectEventosByComunidad(int comunidad, ref string mensaje)
        {
            List<esdeveniments> eventos = null;

            try
            {
                eventos = (from e in ORM.bd.esdeveniments where e.id_comunitat == comunidad orderby e.hora select e).ToList();
            }
            catch (EntityException ex)
            {

                mensaje = "No es posible la conexión con la base de datos. Por ese motivo se cerrará la aplicación";
            }

            return eventos;
        }


        public static String InsertEvento(byte[] img, String nombre, String ubicacion, DateTime fecha_evento,
            DateTime fecha_limite_registro, TimeSpan hora, int comunidad, String descripcion, List<documents> documentos)
        {

            String mensaje = "";


            esdeveniments evento = new esdeveniments();
            evento.img = img;
            evento.nom = nombre;
            evento.ubicació = ubicacion;
            evento.data = fecha_evento;
            evento.data_limit = fecha_limite_registro;
            evento.hora = hora;
            evento.id_comunitat= comunidad;
            evento.descripcio = descripcion;
            evento.documents = documentos;
            ORM.bd.esdeveniments.Add(evento);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        public static String UpdateEvento(esdeveniments evento, byte[] img, String nombre, String ubicacion, DateTime fecha_evento,
            DateTime fecha_limite_registro, TimeSpan hora, int comunidad, String descripcion, List<documents> documentos)
        {

            String mensaje = "";
            evento.img = img;
            evento.nom = nombre;
            evento.ubicació = ubicacion;
            evento.data = fecha_evento;
            evento.data_limit = fecha_limite_registro;
            evento.hora = hora;
            evento.id_comunitat = comunidad;
            evento.descripcio = descripcion;
            evento.documents = documentos;

            mensaje = ORM.SaveChanges();

            return mensaje;

        }

        public static String DeleteEvento(esdeveniments e)
        {
            String mensaje = "";

            List<documents> docs = e.documents.ToList();
            List<assistir> asistir = e.assistir.ToList();

            for (int i = 0; i < docs.Count; i++)
            {
                ORM.bd.documents.Remove(docs[i]);
            }
            for (int i = 0; i < docs.Count; i++)
            {
                ORM.bd.assistir.Remove(asistir[i]);
            }



            ORM.bd.esdeveniments.Remove(e);

            mensaje = ORM.SaveChanges();

            return mensaje;

        }

        public static String DeleteDocumentos(List<documents> docs)
        {
            String mensaje = "";

            for (int i = 0; i < docs.Count; i++)
            {
                ORM.bd.documents.Remove(docs[i]);
            }

            mensaje = ORM.SaveChanges();

            return mensaje;

        }

    }
}