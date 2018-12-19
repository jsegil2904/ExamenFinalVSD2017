using School.DataAccess.Repository.Interfaces;
using School.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School.DataAccess.Repository
{
    public class SeccionRepository :
        GenericRepository<Seccion>, ISeccionRepository
    {
        public SeccionRepository(DbContext pContext) : base(pContext)
        {
        }

        public int GetIdByNombre(string name)
        {
            return ((SchoolModel)context).Seccion
                .Where(item => item.Nombre.Contains(name)).Select(item => item.SeccionID).First();
        }
    }
}
