using School.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository.Interfaces
{
    public interface IAlumnoRepository: IGenericRepository<Alumno>
    {
        IEnumerable<Alumno> GetListByNombres(string names);
    }
}
