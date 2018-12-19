using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Entities.Base;
using School.DataAccess.Repository;
using System.Data.Entity;
using School.DataAccess.Repository.Interfaces;
using System.Linq;

namespace School.DataAccess.Repository.UTest
{
    [TestClass]
    public class AlumnoRepTest
    {

        private readonly DbContext dbContext;
        private readonly IAlumnoRepository alumnoRepository;
        private readonly IUnitOfWork unitOfWork;

        public AlumnoRepTest()
        {
            dbContext = new SchoolModel();
            alumnoRepository = new AlumnoRepository(dbContext);
            unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void Add()
        {
            var alumno = new Alumno();
            alumno.Nombres = "Jorge";
            alumno.Apellidos = "Contreras";
            alumno.Direccion = "Calle Monte Grande 3430 Lima - Peru";
            alumno.Sexo = "Masculino";
            alumno.FechaNacimiento = Convert.ToDateTime("1990/01/20");
            alumnoRepository.Add(alumno);
            dbContext.SaveChanges();

            Assert.IsTrue(alumno.AlumnoID > 0, "OK");

        }

        [TestMethod]
        public void GetByName()
        {
            var cantidad = alumnoRepository.GetListByNombres("Cont").Count();

            Assert.IsTrue(cantidad == 1, "OK");

        }

    }
}
