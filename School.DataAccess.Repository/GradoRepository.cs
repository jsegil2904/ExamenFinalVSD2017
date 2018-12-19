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
    public class GradoRepository :
        GenericRepository<Grado>, IGradosRepository
    {
        public GradoRepository(DbContext pContext) : base(pContext)
        {
        }

        public int GetIdByName(string name)
        {
            return ((SchoolModel)context).Grado
                 .Where(item => item.Nivel.Contains(name)).Select(item=>item.GradoID).First();
        }
    }
}
