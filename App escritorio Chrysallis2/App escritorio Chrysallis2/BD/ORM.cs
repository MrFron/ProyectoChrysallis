using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_escritorio_Chrysallis2
{
    public static class ORM
    {

        public static ChrysallisEntities bd = new ChrysallisEntities();

        public static String MensajesError(SqlException e)
        {

            String mensaje = "";
            switch (e.Number)
            {

                case 2601:
                    mensaje = "Registro duplicado";
                    break;


                default:
                    mensaje = e.Number + " - " + e.Message;

                    break;

            }

            return mensaje;

        }

        public static void RejectChanges()
        {

            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {

                switch (entry.State)
                {

                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default: break;

                }



            }


        }

        public static String SaveChanges()
        {

            String mensaje = "";

            try
            {
                bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                RejectChanges();
                SqlException SqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = MensajesError(SqlEx);
            }
            catch (System.InvalidCastException ex)
            {
                mensaje = ex.ToString();
            }

            return mensaje;


        }



    }
}

