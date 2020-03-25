using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DBSystem.DAL;
using DBSystem.ENTITIES;

namespace DBSystem.BLL
{
    public class Controller02 //Product
    {
        public List<Entity02> FindByID(int id)
        {
            using (var context = new Context())
            {
                IEnumerable<Entity02> results =
                    context.Database.SqlQuery<Entity02>("Products_GetByCategories @ID"
                        , new SqlParameter("ID", id));
                return results.ToList();
            }
        }
        public List<Entity02> FindByPartialName(string partialname)
        {
            using (var context = new Context())
            {
                IEnumerable<Entity02> results =
                    context.Database.SqlQuery<Entity02>("Products_GetByPartialProductName @PartialName",
                                    new SqlParameter("PartialName", partialname));
                return results.ToList();
            }
        }
    }
}
