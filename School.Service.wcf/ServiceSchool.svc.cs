using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using School.Entities.Base;
using School.DataAccess.Repository.Interfaces;
using System.Data.Entity;
using School.DataAccess.Repository;

namespace School.Service.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSchool" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSchool.svc or ServiceSchool.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSchool : IServiceSchool
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly DbContext dbContext;

        public ServiceSchool()
        {
            dbContext = new SchoolModel();
            unitOfWork = new UnitOfWork(dbContext);
        }
        public bool AddAlumno(Alumno alumno)
        {
            unitOfWork.AlumnoRepository.Add(alumno);
            unitOfWork.Complete();
            return true;
        }

        public IEnumerable<Alumno> GetAlumnosByNombes(string alumnoName)
        {
            var alumnos = unitOfWork.AlumnoRepository.GetListByNombres(alumnoName);
            return alumnos;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
       
        public Alumno GetAlumnoById(int id)
        {
            var alumno = unitOfWork.AlumnoRepository.GetByid(id);
            return alumno;
        }

        public IEnumerable<Grado> GetAllGrados()
        {
            var grados = unitOfWork.GradoRepository.GetAll();
            return grados;
        }

        public IEnumerable<Seccion> GetAllSecciones()
        {
            var secciones = unitOfWork.SeccionRepository.GetAll();
            return secciones;
        }

        public int GetIdGrado(string name)
        {
            var id = unitOfWork.GradoRepository.GetIdByName(name);
            return id;
        }

        public bool AddMatricula(Matricula matricula)
        {
            unitOfWork.MatriculaRepository.Add(matricula);
            unitOfWork.Complete();
            return true;
        }

        public int GetIdSeccion(string name)
        {
            var id = unitOfWork.SeccionRepository.GetIdByNombre(name);
            return id;
        }
    }
}
