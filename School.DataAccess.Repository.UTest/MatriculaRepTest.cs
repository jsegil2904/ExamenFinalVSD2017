using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.DataAccess.Repository.Interfaces;
using School.Entities.Base;
using System.Data.Entity;
using School.DataAccess.Repository;

namespace School.DataAccess.Repository.UTest
{
    [TestClass]
    public class MatriculaRepTest
    {
        private readonly DbContext dbContext;
        //private readonly IMatriculaRepository matriculaRepository;
        private readonly IUnitOfWork unitOfWork;

        public MatriculaRepTest()
        {
            dbContext = new SchoolModel();
           // matriculaRepository = new MatriculaRepository(dbContext);
            unitOfWork = new UnitOfWork(dbContext);
        }
        [TestMethod]
        public void Add()
        {
            var matricula = new Matricula();
            matricula.Fecha = Convert.ToDateTime("2018/12/14");
            matricula.GradoID = 1;
            matricula.SeccionID = 1;
            matricula.AlumnoID= 1;
          //  matriculaRepository.Add(matricula);
            dbContext.SaveChanges();

            Assert.IsTrue(matricula.MatriculoID >= 0, "OK");
        }
    }
}
