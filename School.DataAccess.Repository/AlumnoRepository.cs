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
    public class AlumnoRepository :
        GenericRepository<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(DbContext pContext) : base(pContext)
        {
        }

        public IEnumerable<Alumno> GetListByNombres(string names)
        {
            return ((SchoolModel)context).Alumno
                .Where(item => item.Nombres.Contains(names) || item.Apellidos.Contains(names)).ToList();
        }
    }
}
