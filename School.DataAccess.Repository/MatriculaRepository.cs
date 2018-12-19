using School.DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using School.Entities.Base;

namespace School.DataAccess.Repository
{
    public class MatriculaRepository :
        GenericRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(DbContext pContext) : base(pContext)
        {
        }
    }
}
