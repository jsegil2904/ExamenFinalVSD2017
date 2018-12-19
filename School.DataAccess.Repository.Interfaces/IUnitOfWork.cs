using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IAlumnoRepository AlumnoRepository { get; }
        IGradosRepository GradoRepository { get; }
        ISeccionRepository SeccionRepository { get; }

        IMatriculaRepository MatriculaRepository { get; }

        int Complete();

    }
}
