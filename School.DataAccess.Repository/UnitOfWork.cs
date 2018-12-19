using School.DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DbContext _context;

        public IAlumnoRepository AlumnoRepository
        {
            get; private set;
        }

        public IGradosRepository GradoRepository
        {
            get; private set;
        }

        public ISeccionRepository SeccionRepository
        {
            get; private set;
        }

        public IMatriculaRepository MatriculaRepository
        {
            get; private set;
        }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            AlumnoRepository = new AlumnoRepository(_context);
            GradoRepository = new GradoRepository(_context);
            SeccionRepository = new SeccionRepository(_context);
            MatriculaRepository = new MatriculaRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
