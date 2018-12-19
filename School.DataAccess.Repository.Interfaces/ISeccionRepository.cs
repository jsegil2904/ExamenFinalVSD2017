using School.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository.Interfaces
{
    public interface ISeccionRepository : IGenericRepository<Seccion>
    {
        int GetIdByNombre(string name);
    }
}
